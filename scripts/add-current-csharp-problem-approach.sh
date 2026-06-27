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

root="$(pwd)"
source_problem_directory="$root/csharp/src/LeetCode/$problem_name"
test_problem_directory="$root/csharp/tests/LeetCode.Tests/$problem_name"

current_solution_path="$source_problem_directory/$current_approach_name/Solution.cs"
current_tests_path="$test_problem_directory/$current_approach_name/SolutionTests.cs"
test_cases_path="$test_problem_directory/SolutionTestCases.cs"
new_source_approach_directory="$source_problem_directory/$new_approach_name"
new_test_approach_directory="$test_problem_directory/$new_approach_name"

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

if [[ -e "$new_source_approach_directory" || -e "$new_test_approach_directory" ]]; then
    echo "Target approach already exists: $new_approach_name" >&2
    exit 1
fi

mkdir "$new_source_approach_directory" "$new_test_approach_directory"

python3 - "$current_solution_path" "$new_source_approach_directory/Solution.cs" "$problem_name" "$current_approach_name" "$new_approach_name" <<'PY'
from pathlib import Path
import re
import sys

source = Path(sys.argv[1])
target = Path(sys.argv[2])
problem = sys.argv[3]
old = sys.argv[4]
new = sys.argv[5]

text = source.read_text()
text = text.replace(f"namespace LeetCode.{problem}.{old};", f"namespace LeetCode.{problem}.{new};")

class_match = re.search(r"public\s+sealed\s+class\s+Solution\s*\{", text)
if not class_match:
    raise SystemExit("Only Solution-class boilerplate generation is supported. Could not find 'public sealed class Solution'.")

def matching_brace(value: str, open_index: int) -> int:
    depth = 0
    for index in range(open_index, len(value)):
        if value[index] == "{":
            depth += 1
        elif value[index] == "}":
            depth -= 1
            if depth == 0:
                return index
    raise SystemExit("Could not find matching brace.")

class_open = text.index("{", class_match.start())
class_close = matching_brace(text, class_open)
body = text[class_open + 1:class_close]
method_pattern = re.compile(r"(?m)(?P<signature>^\s{4}public\s+(?!sealed\s+class\b)(?!Solution\s*\()[^{;]+?\)\s*)\{")
method_blocks = []

offset = 0
while True:
    match = method_pattern.search(body, offset)
    if not match:
        break
    open_brace = body.index("{", match.start())
    close_brace = matching_brace(body, open_brace)
    signature = match.group("signature").rstrip()
    replacement = f"{signature}\n    {{\n        throw new System.NotImplementedException();\n    }}"
    method_blocks.append(replacement)
    offset = close_brace + 1

if not method_blocks:
    raise SystemExit("Could not find public solution methods to convert to boilerplate.")

target.write_text(text[:class_open + 1] + "\n" + "\n\n".join(method_blocks) + "\n" + text[class_close:])
PY

python3 - "$current_tests_path" "$new_test_approach_directory/SolutionTests.cs" "$problem_name" "$current_approach_name" "$new_approach_name" <<'PY'
from pathlib import Path
import sys

source = Path(sys.argv[1])
target = Path(sys.argv[2])
problem = sys.argv[3]
old = sys.argv[4]
new = sys.argv[5]

text = source.read_text()
text = text.replace(f"LeetCode.{problem}.{old}", f"LeetCode.{problem}.{new}")
text = text.replace(f"LeetCode.Tests.{problem}.{old}", f"LeetCode.Tests.{problem}.{new}")
target.write_text(text)
PY

echo "Created boilerplate approach '$new_approach_name' for problem '$problem_name'."
echo "Source: $new_source_approach_directory/Solution.cs"
echo "Tests:  $new_test_approach_directory/SolutionTests.cs"
