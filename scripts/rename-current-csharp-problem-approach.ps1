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

function Get-ProblemAndApproach {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Directory
    )

    $relativeDirectoryNormalized = $Directory.Replace('\', '/')
    $parts = $relativeDirectoryNormalized.Split('/', [System.StringSplitOptions]::RemoveEmptyEntries)

    for ($i = 0; $i + 4 -lt $parts.Length; $i++) {
        if ($parts[$i] -eq "csharp" -and
            $parts[$i + 1] -eq "src" -and
            $parts[$i + 2] -eq "LeetCode") {
            return @{
                Problem = $parts[$i + 3]
                Approach = $parts[$i + 4]
            }
        }

        if ($parts[$i] -eq "csharp" -and
            $parts[$i + 1] -eq "tests" -and
            $parts[$i + 2] -eq "LeetCode.Tests") {
            return @{
                Problem = $parts[$i + 3]
                Approach = $parts[$i + 4]
            }
        }
    }

    throw "Cannot determine a C# problem and approach from path '$Directory'. Run this task from a file inside a C# approach directory."
}

Assert-ApproachName -Name $NewApproachName

$pathInfo = Get-ProblemAndApproach -Directory $RelativeDirectory
$problemName = $pathInfo.Problem
$currentApproachName = $pathInfo.Approach

if ($currentApproachName -eq $NewApproachName) {
    throw "Approach '$NewApproachName' already matches the current approach."
}

$root = Get-Location
$sourceProblemDirectory = Join-Path $root "csharp/src/LeetCode/$problemName"
$testProblemDirectory = Join-Path $root "csharp/tests/LeetCode.Tests/$problemName"

$currentSourceApproachDirectory = Join-Path $sourceProblemDirectory $currentApproachName
$currentTestApproachDirectory = Join-Path $testProblemDirectory $currentApproachName
$newSourceApproachDirectory = Join-Path $sourceProblemDirectory $NewApproachName
$newTestApproachDirectory = Join-Path $testProblemDirectory $NewApproachName

$currentSolutionPath = Join-Path $currentSourceApproachDirectory "Solution.cs"
$currentTestsPath = Join-Path $currentTestApproachDirectory "SolutionTests.cs"
$testCasesPath = Join-Path $testProblemDirectory "SolutionTestCases.cs"
$newSolutionPath = Join-Path $newSourceApproachDirectory "Solution.cs"
$newTestsPath = Join-Path $newTestApproachDirectory "SolutionTests.cs"

if (-not (Test-Path -LiteralPath $currentSolutionPath -PathType Leaf)) {
    throw "Current approach Solution.cs does not exist: $currentSolutionPath"
}

if (-not (Test-Path -LiteralPath $currentTestsPath -PathType Leaf)) {
    throw "Current approach SolutionTests.cs does not exist: $currentTestsPath"
}

if (-not (Test-Path -LiteralPath $testCasesPath -PathType Leaf)) {
    throw "Shared SolutionTestCases.cs does not exist: $testCasesPath"
}

if (Test-Path -LiteralPath $newSourceApproachDirectory) {
    throw "Target source approach directory already exists: $newSourceApproachDirectory"
}

if (Test-Path -LiteralPath $newTestApproachDirectory) {
    throw "Target test approach directory already exists: $newTestApproachDirectory"
}

$currentSolutionNamespace = "LeetCode.$problemName.$currentApproachName"
$newSolutionNamespace = "LeetCode.$problemName.$NewApproachName"
$currentTestNamespace = "LeetCode.Tests.$problemName.$currentApproachName"
$newTestNamespace = "LeetCode.Tests.$problemName.$NewApproachName"

$solutionContent = Get-Content -LiteralPath $currentSolutionPath -Raw
$testsContent = Get-Content -LiteralPath $currentTestsPath -Raw

if (-not $solutionContent.Contains($currentSolutionNamespace)) {
    throw "Solution.cs does not reference the expected namespace '$currentSolutionNamespace'."
}

if (-not $testsContent.Contains($currentSolutionNamespace)) {
    throw "SolutionTests.cs does not reference the expected solution namespace '$currentSolutionNamespace'."
}

if (-not $testsContent.Contains($currentTestNamespace)) {
    throw "SolutionTests.cs does not reference the expected test namespace '$currentTestNamespace'."
}

$newSolutionContent = $solutionContent.Replace($currentSolutionNamespace, $newSolutionNamespace)
$newTestsContent = $testsContent.
    Replace($currentSolutionNamespace, $newSolutionNamespace).
    Replace($currentTestNamespace, $newTestNamespace)

$sourceMoved = $false
$testsMoved = $false
$utf8NoBom = [System.Text.UTF8Encoding]::new($false)

try {
    Move-Item -LiteralPath $currentSourceApproachDirectory -Destination $newSourceApproachDirectory
    $sourceMoved = $true

    Move-Item -LiteralPath $currentTestApproachDirectory -Destination $newTestApproachDirectory
    $testsMoved = $true

    [System.IO.File]::WriteAllText($newSolutionPath, $newSolutionContent, $utf8NoBom)
    [System.IO.File]::WriteAllText($newTestsPath, $newTestsContent, $utf8NoBom)
}
catch {
    $operationError = $_

    try {
        if ($testsMoved -and (Test-Path -LiteralPath $newTestApproachDirectory)) {
            [System.IO.File]::WriteAllText($newTestsPath, $testsContent, $utf8NoBom)
            Move-Item -LiteralPath $newTestApproachDirectory -Destination $currentTestApproachDirectory
        }

        if ($sourceMoved -and (Test-Path -LiteralPath $newSourceApproachDirectory)) {
            [System.IO.File]::WriteAllText($newSolutionPath, $solutionContent, $utf8NoBom)
            Move-Item -LiteralPath $newSourceApproachDirectory -Destination $currentSourceApproachDirectory
        }
    }
    catch {
        throw "Rename failed: $($operationError.Exception.Message) Rollback also failed: $($_.Exception.Message)"
    }

    throw $operationError
}

Write-Host "Renamed approach '$currentApproachName' to '$NewApproachName' for problem '$problemName'."
Write-Host "Source: $newSolutionPath"
Write-Host "Tests:  $newTestsPath"
