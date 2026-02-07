#!/usr/bin/env sh
set -eu

step() {
  printf '\n==> %s\n' "$1"
}

require_file() {
  path="$1"
  description="$2"
  if [ ! -e "$path" ]; then
    printf "Missing %s at '%s'. Run this script from the turbo-sample-plugin repository root.\n" "$description" "$path" >&2
    exit 1
  fi
}

step "Validating repository layout"
require_file "TurboSamplePlugin.sln" "solution file"
require_file "TurboSamplePlugin/TurboSamplePlugin.csproj" "plugin project"
require_file ".env.example" "environment template"

core_project="../turbo-cloud/Turbo.Main/Turbo.Main.csproj"
require_file "$core_project" "sibling turbo-cloud core project"

step "Checking .NET SDK"
if ! command -v dotnet >/dev/null 2>&1; then
  echo "dotnet is not installed. Install .NET SDK 9.x and rerun." >&2
  exit 1
fi

dotnet_version="$(dotnet --version | tr -d '\r')"
case "$dotnet_version" in
  9.*) ;;
  *)
    printf ".NET SDK 9.x is required. Found '%s'.\n" "$dotnet_version" >&2
    exit 1
    ;;
esac
printf "Using dotnet SDK %s\n" "$dotnet_version"

step "Configuring repository git hooks"
git config --local core.hooksPath .githooks

step "Ensuring local plugin environment file exists"
if [ ! -f ".env" ]; then
  cp .env.example .env
  echo "Created .env from .env.example"
else
  echo ".env already exists"
fi

step "Running plugin smoke build"
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj

step "Bootstrap complete"
echo "Next steps:"
echo "  1) Update PLUGIN_DEV_CONNECTION in .env"
echo "  2) Run: dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj -t:TurboSamplePluginQualityGate"
echo "  3) Optional integrated core+plugin loop: sh scripts/dev-integrated.sh"
