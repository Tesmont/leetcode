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

    $forbiddenNames = @("Best", "Preferred", "Optimal", "Main")

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

    for ($i = 0; $i -lt $parts.Length; $i++) {
        if ($parts[$i] -eq "LeetCode" -and $i + 2 -lt $parts.Length) {
            return @{
                Problem = $parts[$i + 1]
                Approach = $parts[$i + 2]
            }
        }

        if ($parts[$i] -eq "LeetCode.Tests" -and $i + 2 -lt $parts.Length) {
            return @{
                Problem = $parts[$i + 1]
                Approach = $parts[$i + 2]
            }
        }
    }

    throw "Cannot determine problem and approach from path '$Directory'. Run this task from a file inside an approach directory."
}

function Find-MatchingBrace {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Text,

        [Parameter(Mandatory = $true)]
        [int] $OpenBraceIndex
    )

    $depth = 0

    for ($i = $OpenBraceIndex; $i -lt $Text.Length; $i++) {
        if ($Text[$i] -eq '{') {
            $depth++
        }
        elseif ($Text[$i] -eq '}') {
            $depth--

            if ($depth -eq 0) {
                return $i
            }
        }
    }

    throw "Could not find matching brace."
}

function Convert-SolutionToBoilerplate {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Content,

        [Parameter(Mandatory = $true)]
        [string] $ProblemName,

        [Parameter(Mandatory = $true)]
        [string] $OldApproachName,

        [Parameter(Mandatory = $true)]
        [string] $NewApproachName
    )

    $content = $Content.Replace("namespace LeetCode.$ProblemName.$OldApproachName;", "namespace LeetCode.$ProblemName.$NewApproachName;")
    $classMatch = [regex]::Match($content, 'public\s+sealed\s+class\s+Solution\s*\{')

    if (-not $classMatch.Success) {
        throw "Only Solution-class boilerplate generation is supported. Could not find 'public sealed class Solution'."
    }

    $classOpenBrace = $content.IndexOf('{', $classMatch.Index)
    $classCloseBrace = Find-MatchingBrace -Text $content -OpenBraceIndex $classOpenBrace
    $classBody = $content.Substring($classOpenBrace + 1, $classCloseBrace - $classOpenBrace - 1)

    $methodRegex = [regex]'(?m)(?<signature>^\s{4}public\s+(?!sealed\s+class\b)(?!Solution\s*\()[^{;]+?\)\s*)\{'
    $offset = 0

    while ($true) {
        $match = $methodRegex.Match($classBody, $offset)

        if (-not $match.Success) {
            break
        }

        $openBrace = $classBody.IndexOf('{', $match.Index)
        $closeBrace = Find-MatchingBrace -Text $classBody -OpenBraceIndex $openBrace
        $signature = $match.Groups['signature'].Value.TrimEnd()
        $replacement = "$signature`n    {`n        throw new System.NotImplementedException();`n    }"

        $classBody = $classBody.Remove($match.Index, $closeBrace - $match.Index + 1).Insert($match.Index, $replacement)
        $offset = $match.Index + $replacement.Length
    }

    return $content.Substring(0, $classOpenBrace + 1) + $classBody + $content.Substring($classCloseBrace)
}

function Update-TestTemplate {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Content,

        [Parameter(Mandatory = $true)]
        [string] $ProblemName,

        [Parameter(Mandatory = $true)]
        [string] $OldApproachName,

        [Parameter(Mandatory = $true)]
        [string] $NewApproachName
    )

    return $Content.
        Replace("LeetCode.$ProblemName.$OldApproachName", "LeetCode.$ProblemName.$NewApproachName").
        Replace("LeetCode.Tests.$ProblemName.$OldApproachName", "LeetCode.Tests.$ProblemName.$NewApproachName")
}

function Add-ReadmeImplementation {
    param(
        [Parameter(Mandatory = $true)]
        [string] $ReadmePath,

        [Parameter(Mandatory = $true)]
        [string] $ApproachName
    )

    if (-not (Test-Path -LiteralPath $ReadmePath)) {
        throw "README.md does not exist: $ReadmePath"
    }

    $content = Get-Content -LiteralPath $ReadmePath -Raw

    if ($content -match "\| $([regex]::Escape($ApproachName)) \|") {
        Write-Host "README already lists approach '$ApproachName'."
        return
    }

    $line = "| $ApproachName | Unknown | Unknown | Reference |"
    $trimmed = $content.TrimEnd()
    Set-Content -LiteralPath $ReadmePath -Value ($trimmed + "`n" + $line + "`n") -NoNewline
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
$newSolutionPath = Join-Path $newSourceApproachDirectory "Solution.cs"
$newTestsPath = Join-Path $newTestApproachDirectory "SolutionTests.cs"
$readmePath = Join-Path $sourceProblemDirectory "README.md"

if (-not (Test-Path -LiteralPath $currentSolutionPath)) {
    throw "Current approach Solution.cs does not exist: $currentSolutionPath"
}

if (-not (Test-Path -LiteralPath $currentTestsPath)) {
    throw "Current approach SolutionTests.cs does not exist: $currentTestsPath"
}

if (Test-Path -LiteralPath $newSourceApproachDirectory) {
    throw "Target source approach directory already exists: $newSourceApproachDirectory"
}

if (Test-Path -LiteralPath $newTestApproachDirectory) {
    throw "Target test approach directory already exists: $newTestApproachDirectory"
}

New-Item -ItemType Directory -Path $newSourceApproachDirectory | Out-Null
New-Item -ItemType Directory -Path $newTestApproachDirectory | Out-Null

$solutionTemplate = Get-Content -LiteralPath $currentSolutionPath -Raw
$solutionBoilerplate = Convert-SolutionToBoilerplate `
    -Content $solutionTemplate `
    -ProblemName $problemName `
    -OldApproachName $currentApproachName `
    -NewApproachName $NewApproachName
Set-Content -LiteralPath $newSolutionPath -Value $solutionBoilerplate -NoNewline

$testTemplate = Get-Content -LiteralPath $currentTestsPath -Raw
$newTestContent = Update-TestTemplate `
    -Content $testTemplate `
    -ProblemName $problemName `
    -OldApproachName $currentApproachName `
    -NewApproachName $NewApproachName
Set-Content -LiteralPath $newTestsPath -Value $newTestContent -NoNewline

Add-ReadmeImplementation -ReadmePath $readmePath -ApproachName $NewApproachName

Write-Host "Created boilerplate approach '$NewApproachName' for problem '$problemName'."
Write-Host "Source: $newSolutionPath"
Write-Host "Tests:  $newTestsPath"
Write-Host "README updated: $readmePath"
