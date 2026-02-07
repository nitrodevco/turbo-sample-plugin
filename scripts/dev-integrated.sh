#!/usr/bin/env sh
set -eu

build_only=false

if [ "${1:-}" = "--build-only" ]; then
  build_only=true
fi

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

step "Validating plugin repository layout"
require_file "TurboSamplePlugin/TurboSamplePlugin.csproj" "plugin project"

core_project="../turbo-cloud/Turbo.Main/Turbo.Main.csproj"
step "Validating sibling turbo-cloud repository"
require_file "$core_project" "Turbo.Main project"

step "Building plugin"
dotnet build TurboSamplePlugin/TurboSamplePlugin.csproj

step "Building Turbo.Main"
dotnet build "$core_project"

if [ "$build_only" = "true" ]; then
  echo
  echo "Build-only mode complete."
  echo "Next: run this script without --build-only to launch Turbo.Main in Development mode."
  exit 0
fi

core_dev_settings="../turbo-cloud/appsettings.Development.json"
if [ -f "$core_dev_settings" ] && ! grep -q "DevPluginPaths" "$core_dev_settings"; then
  echo "Warning: turbo-cloud/appsettings.Development.json does not contain Turbo:Plugin:DevPluginPaths. The plugin may not be loaded." >&2
fi

step "Running Turbo.Main in Development mode"
DOTNET_ENVIRONMENT=Development dotnet run --project "$core_project"
