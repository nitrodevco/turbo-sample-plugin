param(
    [switch]$BuildOnly
)

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

Write-Step "Validating plugin repository layout"
Require-File "TurboSamplePlugin/TurboSamplePlugin.csproj" "plugin project"

$coreProject = "..\turbo-cloud\Turbo.Main\Turbo.Main.csproj"
Write-Step "Validating sibling turbo-cloud repository"
Require-File $coreProject "Turbo.Main project"

Write-Step "Building plugin"
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj

Write-Step "Building Turbo.Main"
dotnet build $coreProject

if ($BuildOnly) {
    Write-Host ""
    Write-Host "Build-only mode complete."
    Write-Host "Next: run this script without -BuildOnly to launch Turbo.Main in Development mode."
    exit 0
}

$coreDevSettings = "..\turbo-cloud\appsettings.Development.json"
if (Test-Path $coreDevSettings) {
    $hasDevPluginPaths = Select-String -Path $coreDevSettings -Pattern "DevPluginPaths" -Quiet
    if (-not $hasDevPluginPaths) {
        Write-Warning "turbo-cloud/appsettings.Development.json does not contain Turbo:Plugin:DevPluginPaths. The plugin may not be loaded."
    }
}

Write-Step "Running Turbo.Main in Development mode"
$previousEnvironment = $env:DOTNET_ENVIRONMENT
try {
    $env:DOTNET_ENVIRONMENT = "Development"
    dotnet run --project $coreProject
}
finally {
    $env:DOTNET_ENVIRONMENT = $previousEnvironment
}
