#!/usr/bin/env bash
set -euo pipefail

relative_directory="${1:?Relative directory is required.}"
new_approach_name="${2:?New approach name is required.}"

assert_approach_name() {
    local name="$1"

    if [[ ! "$name" =~ ^[A-Z][A-Za-z0-9]*$ ]]; then
        echo "Approach name must be PascalCase and contain only letters and digits. Actual: '$name'." >&2
        exit 1
    fi

    case "$name" in
        Best|Preferred|Optimal|Main)
            echo "Approach name '$name' is forbidden by repository rules. Use a real approach name, e.g. TwoPointers, Stack, DynamicProgramming." >&2
            exit 1
            ;;
    esac
}

replace_text_in_files() {
    local directory="$1"
    local old_text="$2"
    local new_text="$3"

    if [[ ! -d "$directory" ]]; then
        return
    fi

    python3 - "$directory" "$old_text" "$new_text" <<'PY'
from pathlib import Path
import sys

directory = Path(sys.argv[1])
old_text = sys.argv[2]
new_text = sys.argv[3]

for path in directory.rglob("*.cs"):
    content = path.read_text()
    if old_text in content:
        path.write_text(content.replace(old_text, new_text))
PY
}

assert_approach_name "$new_approach_name"

relative_directory_normalized="${relative_directory//\\//}"
IFS='/' read -r -a parts <<< "$relative_directory_normalized"

problem_name=""
old_approach_name=""

for ((i = 0; i < ${#parts[@]}; i++)); do
    if [[ "${parts[$i]}" == "LeetCode" && $((i + 2)) -lt ${#parts[@]} ]]; then
        problem_name="${parts[$((i + 1))]}"
        old_approach_name="${parts[$((i + 2))]}"
        break
    fi

    if [[ "${parts[$i]}" == "LeetCode.Tests" && $((i + 2)) -lt ${#parts[@]} ]]; then
        problem_name="${parts[$((i + 1))]}"
        old_approach_name="${parts[$((i + 2))]}"
        break
    fi
done

if [[ -z "$problem_name" || -z "$old_approach_name" ]]; then
    echo "Cannot determine problem and approach from path '$relative_directory'. Run this task from a file inside an approach directory." >&2
    exit 1
fi

if [[ "$old_approach_name" == "$new_approach_name" ]]; then
    echo "Approach is already named '$new_approach_name'. Nothing to rename."
    exit 0
fi

root="$(pwd)"

source_problem_directory="$root/csharp/src/LeetCode/$problem_name"
test_problem_directory="$root/csharp/tests/LeetCode.Tests/$problem_name"

old_source_approach_directory="$source_problem_directory/$old_approach_name"
new_source_approach_directory="$source_problem_directory/$new_approach_name"

old_test_approach_directory="$test_problem_directory/$old_approach_name"
new_test_approach_directory="$test_problem_directory/$new_approach_name"

readme_path="$source_problem_directory/README.md"

if [[ ! -d "$old_source_approach_directory" ]]; then
    echo "Source approach directory does not exist: $old_source_approach_directory" >&2
    exit 1
fi

if [[ -e "$new_source_approach_directory" ]]; then
    echo "Target source approach directory already exists: $new_source_approach_directory" >&2
    exit 1
fi

if [[ -d "$old_test_approach_directory" && -e "$new_test_approach_directory" ]]; then
    echo "Target test approach directory already exists: $new_test_approach_directory" >&2
    exit 1
fi

mv "$old_source_approach_directory" "$new_source_approach_directory"

if [[ -d "$old_test_approach_directory" ]]; then
    mv "$old_test_approach_directory" "$new_test_approach_directory"
fi

old_source_namespace="LeetCode.$problem_name.$old_approach_name"
new_source_namespace="LeetCode.$problem_name.$new_approach_name"

old_test_namespace="LeetCode.Tests.$problem_name.$old_approach_name"
new_test_namespace="LeetCode.Tests.$problem_name.$new_approach_name"

replace_text_in_files "$new_source_approach_directory" "$old_source_namespace" "$new_source_namespace"
replace_text_in_files "$new_test_approach_directory" "$old_test_namespace" "$new_test_namespace"
replace_text_in_files "$new_test_approach_directory" "$old_source_namespace" "$new_source_namespace"

if [[ -f "$readme_path" ]]; then
    python3 - "$readme_path" "$old_approach_name" "$new_approach_name" <<'PY'
from pathlib import Path
import sys

path = Path(sys.argv[1])
old_text = sys.argv[2]
new_text = sys.argv[3]

content = path.read_text()
if old_text in content:
    path.write_text(content.replace(old_text, new_text))
PY
fi

echo "Renamed approach '$old_approach_name' to '$new_approach_name' for problem '$problem_name'."
echo "Source: $old_source_namespace -> $new_source_namespace"
echo "Tests:  $old_test_namespace -> $new_test_namespace"
