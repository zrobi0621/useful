# C:\Users\<USER>\Documents\WindowsPowerShell
# Modified prompt for PowerShell

function prompt {
    # Actual path
    Write-Host (Get-Location) -NoNewline -ForegroundColor Green

    # Git branch 
    if (Test-Path .git) {
        $branch = & git rev-parse --abbrev-ref HEAD 2>$null
        if ($branch) {
            Write-Host " [$branch]" -NoNewline -ForegroundColor Magenta
        }
    }

    # Original prompt
    Write-Host " PS > " -NoNewline -ForegroundColor Cyan
    return " "
}
