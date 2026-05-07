#!/usr/bin/env bash
set -euo pipefail

path="${1:-}"

if [[ -z "$path" ]]; then
    echo "Missing file path." >&2
    exit 1
fi

if [[ ! -f "$path" ]]; then
    echo "File does not exist: $path" >&2
    exit 1
fi

commit_message="$(
    awk '
        {
            text = $0
            sub(/^[[:space:]]*\/\/\/[[:space:]]?/, "", text)

            if (!inside) {
                if (text ~ /<summary>/) {
                    inside = 1
                    sub(/^.*<summary>/, "", text)
                } else {
                    next
                }
            }

            if (text ~ /<\/summary>/) {
                sub(/<\/summary>.*$/, "", text)
                inside = 0
            }

            gsub(/^[[:space:]]+|[[:space:]]+$/, "", text)
            if (length(text) > 0) {
                print text
                exit
            }
        }
    ' "$path"
)"

if [[ -z "$commit_message" ]]; then
    echo "Could not find a commit message in the first line of the summary block: $path" >&2
    exit 1
fi

echo "Commit message: $commit_message"

git add --all

if git diff --cached --quiet; then
    echo "No staged changes to commit."
    exit 0
fi

git commit -m "$commit_message"
git push
