param(
    [Parameter(Mandatory = $true)]
    [string] $RelativeDirectory,

    [Parameter(Mandatory = $true)]
    [string] $NewApproachName
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

function Assert-ApproachName {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Name
    )

    if ($Name -notmatch '^[A-Z][A-Za-z0-9]*$') {
        throw "Approach name must be PascalCase and contain only letters and digits. Actual: '$Name'."
    }

    $forbiddenNames = @(
        "Best",
        "Preferred",
        "Optimal",
        "Main",
        "Temp",
        "New",
        "Try2",
        "Better",
        "Final",
        "Optimized2",
        "Solution1",
        "Solution2"
    )

    if ($forbiddenNames -contains $Name) {
        throw "Approach name '$Name' is forbidden by repository rules. Use a real approach name, e.g. TwoPointers, Stack, DynamicProgramming."
    }
}

function Replace-TextInFiles {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Directory,

        [Parameter(Mandatory = $true)]
        [string] $OldText,

        [Parameter(Mandatory = $true)]
        [string] $NewText,

        [Parameter(Mandatory = $true)]
        [string[]] $Patterns
    )

    if (-not (Test-Path -LiteralPath $Directory)) {
        return
    }

    foreach ($pattern in $Patterns) {
        Get-ChildItem -LiteralPath $Directory -Recurse -File -Filter $pattern |
            ForEach-Object {
                $content = Get-Content -LiteralPath $_.FullName -Raw

                if ($content.Contains($OldText)) {
                    $content = $content.Replace($OldText, $NewText)
                    Set-Content -LiteralPath $_.FullName -Value $content -NoNewline
                }
            }
    }
}

Assert-ApproachName -Name $NewApproachName

$relativeDirectoryNormalized = $RelativeDirectory.Replace('\', '/')
$parts = $relativeDirectoryNormalized.Split('/', [System.StringSplitOptions]::RemoveEmptyEntries)

$problemName = $null
$oldApproachName = $null

for ($i = 0; $i -lt $parts.Length; $i++) {
    if ($parts[$i] -eq "LeetCode" -and $i + 2 -lt $parts.Length) {
        $problemName = $parts[$i + 1]
        $oldApproachName = $parts[$i + 2]
        break
    }

    if ($parts[$i] -eq "LeetCode.Tests" -and $i + 2 -lt $parts.Length) {
        $problemName = $parts[$i + 1]
        $oldApproachName = $parts[$i + 2]
        break
    }
}

if ([string]::IsNullOrWhiteSpace($problemName) -or [string]::IsNullOrWhiteSpace($oldApproachName)) {
    throw "Cannot determine problem and approach from path '$RelativeDirectory'. Run this task from a file inside an approach directory."
}

if ($oldApproachName -eq $NewApproachName) {
    Write-Host "Approach is already named '$NewApproachName'. Nothing to rename."
    exit 0
}

$root = Get-Location

$sourceProblemDirectory = Join-Path $root "csharp/src/LeetCode/$problemName"
$testProblemDirectory = Join-Path $root "csharp/tests/LeetCode.Tests/$problemName"

$oldSourceApproachDirectory = Join-Path $sourceProblemDirectory $oldApproachName
$newSourceApproachDirectory = Join-Path $sourceProblemDirectory $NewApproachName

$oldTestApproachDirectory = Join-Path $testProblemDirectory $oldApproachName
$newTestApproachDirectory = Join-Path $testProblemDirectory $NewApproachName

$readmePath = Join-Path $sourceProblemDirectory "README.md"

if (-not (Test-Path -LiteralPath $oldSourceApproachDirectory)) {
    throw "Source approach directory does not exist: $oldSourceApproachDirectory"
}

if (Test-Path -LiteralPath $newSourceApproachDirectory) {
    throw "Target source approach directory already exists: $newSourceApproachDirectory"
}

if ((Test-Path -LiteralPath $oldTestApproachDirectory) -and (Test-Path -LiteralPath $newTestApproachDirectory)) {
    throw "Target test approach directory already exists: $newTestApproachDirectory"
}

Rename-Item -LiteralPath $oldSourceApproachDirectory -NewName $NewApproachName

if (Test-Path -LiteralPath $oldTestApproachDirectory) {
    Rename-Item -LiteralPath $oldTestApproachDirectory -NewName $NewApproachName
}

$oldSourceNamespace = "LeetCode.$problemName.$oldApproachName"
$newSourceNamespace = "LeetCode.$problemName.$NewApproachName"

$oldTestNamespace = "LeetCode.Tests.$problemName.$oldApproachName"
$newTestNamespace = "LeetCode.Tests.$problemName.$NewApproachName"

Replace-TextInFiles `
    -Directory $newSourceApproachDirectory `
    -OldText $oldSourceNamespace `
    -NewText $newSourceNamespace `
    -Patterns @("*.cs")

Replace-TextInFiles `
    -Directory $newTestApproachDirectory `
    -OldText $oldTestNamespace `
    -NewText $newTestNamespace `
    -Patterns @("*.cs")

Replace-TextInFiles `
    -Directory $newTestApproachDirectory `
    -OldText $oldSourceNamespace `
    -NewText $newSourceNamespace `
    -Patterns @("*.cs")

if (Test-Path -LiteralPath $readmePath) {
    $readmeContent = Get-Content -LiteralPath $readmePath -Raw

    if ($readmeContent.Contains($oldApproachName)) {
        $readmeContent = $readmeContent.Replace($oldApproachName, $NewApproachName)
        Set-Content -LiteralPath $readmePath -Value $readmeContent -NoNewline
    }
}

Write-Host "Renamed approach '$oldApproachName' to '$NewApproachName' for problem '$problemName'."
Write-Host "Source: $oldSourceNamespace -> $newSourceNamespace"
Write-Host "Tests:  $oldTestNamespace -> $newTestNamespace"
