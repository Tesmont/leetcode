param(
    [Parameter(Mandatory = $true)]
    [string] $Path
)

if (-not (Test-Path -LiteralPath $Path)) {
    Write-Error "File does not exist: $Path"
    exit 1
}

$lines = Get-Content -LiteralPath $Path
$insideSummary = $false
$commitMessage = $null

foreach ($line in $lines) {
    $text = $line -replace '^\s*///\s?', ''

    if (-not $insideSummary) {
        if ($text -match '<summary>') {
            $insideSummary = $true
            $text = $text -replace '^.*<summary>', ''
        }
        else {
            continue
        }
    }

    if ($text -match '</summary>') {
        $text = $text -replace '</summary>.*$', ''
        $insideSummary = $false
    }

    $text = $text.Trim()
    if ($text.Length -gt 0) {
        $commitMessage = $text
        break
    }
}

if ([string]::IsNullOrWhiteSpace($commitMessage)) {
    Write-Error "Could not find a commit message in the first line of the summary block: $Path"
    exit 1
}

Write-Host "Commit message: $commitMessage"

git add --all
if ($LASTEXITCODE -ne 0) {
    exit $LASTEXITCODE
}

git diff --cached --quiet
if ($LASTEXITCODE -eq 0) {
    Write-Host "No staged changes to commit."
    exit 0
}

git commit -m $commitMessage
if ($LASTEXITCODE -ne 0) {
    exit $LASTEXITCODE
}

git push
exit $LASTEXITCODE
