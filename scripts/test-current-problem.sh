#!/usr/bin/env bash
set -euo pipefail

path="${1//\\//}"
IFS='/' read -r -a parts <<< "$path"

filter=""

for part in "${parts[@]}"; do
    if [[ -n "$filter" ]]; then
        filter="${filter}.${part}"
        continue
    fi

    if [[ "$part" =~ ^P[0-9]{5} ]]; then
        filter="$part"
    fi
done

if [[ -z "$filter" ]]; then
    echo "Could not find a problem directory in: $1" >&2
    exit 1
fi

echo "Running tests matching $filter"
dotnet test csharp/LeetCode.slnx --filter "FullyQualifiedName~${filter}"
