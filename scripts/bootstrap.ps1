Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

function Write-Step {
    param([string]$Message)
    Write-Host ""
    Write-Host "==> $Message"
}

function Require-File {
    param([string]$Path, [string]$Description)
    if (-not (Test-Path $Path)) {
        throw "Missing $Description at '$Path'. Run this script from the turbo-sample-plugin repository root."
    }
}

Write-Step "Validating repository layout"
Require-File "TurboSamplePlugin.sln" "solution file"
Require-File "TurboSamplePlugin/TurboSamplePlugin.csproj" "plugin project"
Require-File ".env.example" "environment template"

$coreProject = "..\turbo-cloud\Turbo.Main\Turbo.Main.csproj"
Require-File $coreProject "sibling turbo-cloud core project"

Write-Step "Checking .NET SDK"
if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    throw "dotnet is not installed. Install .NET SDK 9.x and rerun."
}

$dotnetVersion = (dotnet --version).Trim()
if (-not $dotnetVersion.StartsWith("9.")) {
    throw ".NET SDK 9.x is required. Found '$dotnetVersion'."
}
Write-Host "Using dotnet SDK $dotnetVersion"

Write-Step "Configuring repository git hooks"
git config --local core.hooksPath .githooks

Write-Step "Ensuring local plugin environment file exists"
if (-not (Test-Path ".env")) {
    Copy-Item ".env.example" ".env"
    Write-Host "Created .env from .env.example"
} else {
    Write-Host ".env already exists"
}

Write-Step "Running plugin smoke build"
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj

Write-Step "Bootstrap complete"
Write-Host "Next steps:"
Write-Host "  1) Update PLUGIN_DEV_CONNECTION in .env"
Write-Host "  2) Run: dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate"
Write-Host "  3) Optional integrated core+plugin loop: pwsh -File scripts/dev-integrated.ps1"
