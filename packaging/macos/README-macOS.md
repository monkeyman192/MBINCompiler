# MBINCompiler for macOS (Apple Silicon)

This archive contains the command-line **MBINCompiler** built for Apple Silicon
(`osx-arm64`) on **.NET 8**.

```
MBINCompiler     the executable
libMBIN.dll      the data library  ←  MUST stay in the same folder as MBINCompiler
```

## Requirements

- An **Apple Silicon** Mac (M1 or newer).
- The **.NET 8 runtime** (this is a framework-dependent build, so it is small but
  needs the runtime installed). Get it from
  <https://dotnet.microsoft.com/download/dotnet/8.0/runtime> or install with
  Homebrew: `brew install --cask dotnet-sdk`.

  Don't want to install .NET at all? Use the drag-and-drop **MBINCompiler app**
  instead — it bundles everything. See "The app" at the bottom.

## Quick start

Because macOS quarantines files downloaded from the internet, clear the flag and
make the binary executable the first time:

```sh
xattr -dr com.apple.quarantine .          # remove the "downloaded from internet" flag
chmod +x MBINCompiler                      # make it runnable
./MBINCompiler help                        # check it works
./MBINCompiler /path/to/file.MBIN          # convert a file (MBIN→MXML or MXML→MBIN)
```

`MBINCompiler` and `libMBIN.dll` must always live **in the same directory**.

## Putting it on your PATH

The included script does it for you — it copies both files to
`~/.local/share/mbincompiler` and symlinks the binary into a folder on your PATH:

```sh
./install.sh
```

Then you can run `mbincompiler ...` from anywhere. (A symlink is fine: the binary
still finds `libMBIN.dll` next to its real location.)

To do it by hand instead, keep the two files together in a folder and add that
folder to your PATH, e.g. in `~/.zshrc`:

```sh
export PATH="$HOME/tools/mbincompiler:$PATH"
```

Do **not** copy only `MBINCompiler` into `/usr/local/bin` on its own — it will
fail to find `libMBIN.dll`.

## The app (no .NET install required)

If you'd rather drag-and-drop files onto a window with clickable options, build
the **MBINCompiler.app** from the source repository:

```sh
git clone https://github.com/monkeyman192/MBINCompiler
cd MBINCompiler
./install_mac_gui
```

That produces a self-contained, code-signed app in `~/Applications` that needs no
.NET runtime of its own (building it needs the .NET SDK + Xcode command-line
tools). See the main README for details.
