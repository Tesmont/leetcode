param(
    [Parameter(Mandatory = $true)]
    [string] $Path
)

$normalized = $Path -replace '\\', '/'
$parts = $normalized -split '/'
$problemIndex = -1

for ($i = 0; $i -lt $parts.Length; $i++) {
    if ($parts[$i] -match '^P\d{5}') {
        $problemIndex = $i
        break
    }
}

if ($problemIndex -lt 0) {
    Write-Error "Could not find a problem directory in: $Path"
    exit 1
}

$filter = $parts[$problemIndex..($parts.Length - 1)] -join '.'

Write-Host "Running tests matching $filter"
dotnet test csharp/LeetCode.slnx --filter "FullyQualifiedName~$filter"
exit $LASTEXITCODE
