#!/bin/bash
# install-cli.sh — install the MBINCompiler command-line tool onto your PATH.
#
# Ships next to `MBINCompiler` and `libMBIN.dll` in the macOS release archive.
# It keeps the two files together (the binary needs libMBIN.dll beside it) in
# ~/.local/share/mbincompiler and symlinks the executable into a PATH directory.
set -euo pipefail

HERE="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SHARE="$HOME/.local/share/mbincompiler"
BOLD=$'\033[1m'; GREEN=$'\033[32m'; YELLOW=$'\033[33m'; RESET=$'\033[0m'
say()  { echo "${BOLD}${GREEN}==>${RESET}${BOLD} $*${RESET}"; }
warn() { echo "${BOLD}${YELLOW}warning:${RESET} $*"; }
die()  { echo "${BOLD}error:${RESET} $*" >&2; exit 1; }

[ -f "$HERE/MBINCompiler" ] || die "MBINCompiler not found next to this script."
[ -f "$HERE/libMBIN.dll" ] || die "libMBIN.dll not found next to this script — it must ship alongside MBINCompiler."

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
cp "$HERE/MBINCompiler" "$HERE/libMBIN.dll" "$SHARE/"
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
        *":$(dirname "$linked"):"*) say "Done. Run:  mbincompiler help" ;;
        *) warn "$(dirname "$linked") isn't on your PATH. Add it, then run:  mbincompiler help" ;;
    esac
else
    warn "No writable bin directory found. Add this line to your ~/.zshrc instead:"
    warn "  export PATH=\"$SHARE:\$PATH\""
    say  "Then run:  mbincompiler help   (or $SHARE/MBINCompiler help)"
fi
