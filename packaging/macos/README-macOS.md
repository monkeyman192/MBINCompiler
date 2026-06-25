# MBINCompiler for macOS (Apple Silicon)

This archive contains the command-line **MBINCompiler** built for Apple Silicon
(`osx-arm64`) on **.NET 8**, plus two optional drag-and-drop helpers.

```
MBINCompiler                       the executable
libMBIN.dll                        the data library  ←  MUST stay next to MBINCompiler
install.sh                         puts MBINCompiler on your PATH + installs the extras
MBINCompiler Droplet.app           drag .MBIN/.MXML files onto it to convert
MBINCompiler-QuickAction.workflow  Finder right-click "Convert with MBINCompiler"
```

## Requirements

- An **Apple Silicon** Mac (M1 or newer).
- The **.NET 8 runtime** (this is a framework-dependent build, so it is small but
  needs the runtime installed). Get it from
  <https://dotnet.microsoft.com/download/dotnet/8.0/runtime> or install with
  Homebrew: `brew install --cask dotnet-sdk`.

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
`~/.local/share/mbincompiler`, symlinks the binary as `mbincompiler` into a folder
on your PATH, and installs the Quick Action:

```sh
./install.sh
```

Then you can run `mbincompiler ...` from anywhere. (A symlink is fine: the binary
still finds `libMBIN.dll` next to its real location.) If the chosen folder isn't on
your PATH, the script tells you what to add to `~/.zshrc`.

To do it by hand instead, keep the two files together in a folder and add that
folder to your PATH, e.g. in `~/.zshrc`:

```sh
export PATH="$HOME/tools/mbincompiler:$PATH"
```

Do **not** copy only `MBINCompiler` into `/usr/local/bin` on its own — it will
fail to find `libMBIN.dll`.

## Drag-and-drop helpers

Both call the `mbincompiler` command, so run `./install.sh` first. They convert in
place: drop/select an `.MBIN` → you get an `.MXML` beside it, and vice versa.

- **Droplet** — drag `.MBIN`/`.MXML` files onto **`MBINCompiler Droplet.app`**. Move
  it to `/Applications` or your Dock to keep it around.
- **Finder Quick Action** — `install.sh` installs it; or double-click
  **`MBINCompiler-QuickAction.workflow`** to install it yourself. Then right-click any
  `.MBIN`/`.MXML` in Finder ▸ **Quick Actions ▸ Convert with MBINCompiler**.

> macOS launches these without your shell's PATH, so they look for `mbincompiler` in
> the standard locations `install.sh` uses (`/opt/homebrew/bin`, `/usr/local/bin`,
> `~/.local/bin`). If it isn't found you'll get a prompt telling you to run `install.sh`.
