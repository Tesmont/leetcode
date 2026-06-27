#!/usr/bin/env bash
set -euo pipefail

relative_directory="${1:?Relative directory is required.}"
new_approach_name="${2:?New approach name is required.}"

if [[ ! "$new_approach_name" =~ ^[A-Z][A-Za-z0-9]*$ ]]; then
    echo "Approach name must be PascalCase and contain only letters and digits. Actual: '$new_approach_name'." >&2
    exit 1
fi

case "$new_approach_name" in
    Best|Preferred|Optimal|Main|Temp|New|Try2|Better|Final|Optimized2|Solution1|Solution2)
        echo "Approach name '$new_approach_name' is forbidden by repository rules. Use a real approach name, e.g. TwoPointers, Stack, DynamicProgramming." >&2
        exit 1
        ;;
esac

relative_directory_normalized="${relative_directory//\\//}"
IFS='/' read -r -a parts <<< "$relative_directory_normalized"

problem_name=""
current_approach_name=""

for ((i = 0; i + 4 < ${#parts[@]}; i++)); do
    if [[ "${parts[$i]}" == "csharp" && "${parts[$((i + 1))]}" == "src" && "${parts[$((i + 2))]}" == "LeetCode" ]]; then
        problem_name="${parts[$((i + 3))]}"
        current_approach_name="${parts[$((i + 4))]}"
        break
    fi

    if [[ "${parts[$i]}" == "csharp" && "${parts[$((i + 1))]}" == "tests" && "${parts[$((i + 2))]}" == "LeetCode.Tests" ]]; then
        problem_name="${parts[$((i + 3))]}"
        current_approach_name="${parts[$((i + 4))]}"
        break
    fi
done

if [[ -z "$problem_name" || -z "$current_approach_name" ]]; then
    echo "Cannot determine a C# problem and approach from path '$relative_directory'. Run this task from a file inside a C# approach directory." >&2
    exit 1
fi

if [[ "$current_approach_name" == "$new_approach_name" ]]; then
    echo "Approach '$new_approach_name' already matches the current approach." >&2
    exit 1
fi

root="$(pwd)"
source_problem_directory="$root/csharp/src/LeetCode/$problem_name"
test_problem_directory="$root/csharp/tests/LeetCode.Tests/$problem_name"

current_source_approach_directory="$source_problem_directory/$current_approach_name"
current_test_approach_directory="$test_problem_directory/$current_approach_name"
new_source_approach_directory="$source_problem_directory/$new_approach_name"
new_test_approach_directory="$test_problem_directory/$new_approach_name"

current_solution_path="$current_source_approach_directory/Solution.cs"
current_tests_path="$current_test_approach_directory/SolutionTests.cs"
test_cases_path="$test_problem_directory/SolutionTestCases.cs"

if [[ ! -f "$current_solution_path" ]]; then
    echo "Current approach Solution.cs does not exist: $current_solution_path" >&2
    exit 1
fi

if [[ ! -f "$current_tests_path" ]]; then
    echo "Current approach SolutionTests.cs does not exist: $current_tests_path" >&2
    exit 1
fi

if [[ ! -f "$test_cases_path" ]]; then
    echo "Shared SolutionTestCases.cs does not exist: $test_cases_path" >&2
    exit 1
fi

if [[ -e "$new_source_approach_directory" ]]; then
    echo "Target source approach directory already exists: $new_source_approach_directory" >&2
    exit 1
fi

if [[ -e "$new_test_approach_directory" ]]; then
    echo "Target test approach directory already exists: $new_test_approach_directory" >&2
    exit 1
fi

python3 - "$current_source_approach_directory" "$current_test_approach_directory" "$new_source_approach_directory" "$new_test_approach_directory" "$problem_name" "$current_approach_name" "$new_approach_name" <<'PY'
from pathlib import Path
import sys

source_directory = Path(sys.argv[1])
test_directory = Path(sys.argv[2])
new_source_directory = Path(sys.argv[3])
new_test_directory = Path(sys.argv[4])
problem = sys.argv[5]
old = sys.argv[6]
new = sys.argv[7]

solution_path = source_directory / "Solution.cs"
tests_path = test_directory / "SolutionTests.cs"
solution_content = solution_path.read_bytes()
tests_content = tests_path.read_bytes()

old_solution_namespace = f"LeetCode.{problem}.{old}".encode()
new_solution_namespace = f"LeetCode.{problem}.{new}".encode()
old_test_namespace = f"LeetCode.Tests.{problem}.{old}".encode()
new_test_namespace = f"LeetCode.Tests.{problem}.{new}".encode()

if old_solution_namespace not in solution_content:
    raise SystemExit(f"Solution.cs does not reference the expected namespace '{old_solution_namespace.decode()}'.")

if old_solution_namespace not in tests_content:
    raise SystemExit(f"SolutionTests.cs does not reference the expected solution namespace '{old_solution_namespace.decode()}'.")

if old_test_namespace not in tests_content:
    raise SystemExit(f"SolutionTests.cs does not reference the expected test namespace '{old_test_namespace.decode()}'.")

new_solution_content = solution_content.replace(old_solution_namespace, new_solution_namespace)
new_tests_content = tests_content.replace(old_solution_namespace, new_solution_namespace).replace(old_test_namespace, new_test_namespace)

source_moved = False
tests_moved = False

try:
    source_directory.rename(new_source_directory)
    source_moved = True

    test_directory.rename(new_test_directory)
    tests_moved = True

    (new_source_directory / "Solution.cs").write_bytes(new_solution_content)
    (new_test_directory / "SolutionTests.cs").write_bytes(new_tests_content)
except Exception as error:
    rollback_errors = []

    if tests_moved and new_test_directory.exists():
        try:
            (new_test_directory / "SolutionTests.cs").write_bytes(tests_content)
            new_test_directory.rename(test_directory)
        except Exception as rollback_error:
            rollback_errors.append(str(rollback_error))

    if source_moved and new_source_directory.exists():
        try:
            (new_source_directory / "Solution.cs").write_bytes(solution_content)
            new_source_directory.rename(source_directory)
        except Exception as rollback_error:
            rollback_errors.append(str(rollback_error))

    if rollback_errors:
        raise SystemExit(f"Rename failed: {error}. Rollback also failed: {'; '.join(rollback_errors)}") from error

    raise SystemExit(f"Rename failed: {error}") from error
PY

echo "Renamed approach '$current_approach_name' to '$new_approach_name' for problem '$problem_name'."
echo "Source: $new_source_approach_directory/Solution.cs"
echo "Tests:  $new_test_approach_directory/SolutionTests.cs"
