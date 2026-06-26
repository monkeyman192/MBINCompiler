#!/bin/bash
# install-cli.sh — install the MBINCompiler command-line tool onto your PATH.
#
# Ships next to `MBINCompiler` in the macOS release archive. The single-file build
# is self-contained (libMBIN is embedded), so this just copies the executable to
# ~/.local/share/mbincompiler and symlinks it into a PATH directory.
set -euo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SHARE="$HOME/.local/share/mbincompiler"
BOLD=$'\033[1m'; GREEN=$'\033[32m'; YELLOW=$'\033[33m'; RESET=$'\033[0m'
say()  { echo "${BOLD}${GREEN}==>${RESET}${BOLD} $*${RESET}"; }
warn() { echo "${BOLD}${YELLOW}warning:${RESET} $*"; }
die()  { echo "${BOLD}error:${RESET} $*" >&2; exit 1; }

[ -f "$HERE/MBINCompiler" ] || die "MBINCompiler not found next to this script."

# Clear the quarantine flag (downloaded-from-internet) and make it runnable.
xattr -dr com.apple.quarantine "$HERE" 2>/dev/null || true
chmod +x "$HERE/MBINCompiler"

# .NET 8 runtime check (this is a framework-dependent build).
if ! command -v dotnet >/dev/null 2>&1; then
    warn "The .NET runtime wasn't found. Install .NET 8 to run MBINCompiler:"
    warn "  https://dotnet.microsoft.com/download/dotnet/8.0/runtime   (or: brew install --cask dotnet-sdk)"
fi

say "Installing to $SHARE …"
mkdir -p "$SHARE"
cp "$HERE/MBINCompiler" "$SHARE/"
chmod +x "$SHARE/MBINCompiler"

linked=""
for bin in /opt/homebrew/bin /usr/local/bin "$HOME/.local/bin"; do
    if [ -d "$bin" ] && [ -w "$bin" ]; then
        ln -sf "$SHARE/MBINCompiler" "$bin/mbincompiler"
        linked="$bin/mbincompiler"
        break
    fi
done

if [ -n "$linked" ]; then
    say "Linked: $linked"
    case ":$PATH:" in
        *":$(dirname "$linked"):"*) say "Command-line tool ready. Run:  mbincompiler help" ;;
        *) warn "$(dirname "$linked") isn't on your PATH. Add it, then run:  mbincompiler help" ;;
    esac
else
    warn "No writable bin directory found. Add this line to your ~/.zshrc instead:"
    warn "  export PATH=\"$SHARE:\$PATH\""
    say  "Then run:  mbincompiler help   (or $SHARE/MBINCompiler help)"
fi

# Install the Finder "Convert with MBINCompiler" Quick Action, if it shipped here.
QA="MBINCompiler-QuickAction.workflow"
if [ -d "$HERE/$QA" ]; then
    mkdir -p "$HOME/Library/Services"
    rm -rf "$HOME/Library/Services/$QA"
    cp -R "$HERE/$QA" "$HOME/Library/Services/"
    /System/Library/CoreServices/pbs -flush 2>/dev/null || true
    say "Installed Quick Action → right-click a .MBIN/.MXML file in Finder ▸ Quick Actions ▸ Convert with MBINCompiler"
fi

# Point out the drag-and-drop droplet, if it shipped here.
if [ -d "$HERE/MBINCompiler Droplet.app" ]; then
    say "Drag-and-drop: drop .MBIN/.MXML files onto 'MBINCompiler Droplet.app' (move it to /Applications or your Dock to keep it handy)."
fi
