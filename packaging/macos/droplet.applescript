-- MBINCompiler droplet — drag .MBIN/.MXML files onto the app icon to convert them.
-- MBIN → MXML and MXML → MBIN are auto-detected; output is written next to each
-- source file. Requires the `mbincompiler` command on your PATH (run install.sh).
--
-- Compiled to an .app with:  osacompile -o "MBINCompiler Droplet.app" droplet.applescript

-- Find the `mbincompiler` command. GUI-launched apps don't inherit your shell PATH,
-- so we add the locations install.sh uses before resolving it.
on findTool()
	set pathSetup to "for d in \"$HOME/.local/bin\" /opt/homebrew/bin /usr/local/bin; do [ -x \"$d/mbincompiler\" ] && export PATH=\"$d:$PATH\"; done; "
	try
		return do shell script pathSetup & "command -v mbincompiler"
	on error
		display dialog "MBINCompiler isn't on your PATH yet." & return & return & "Run install.sh from the MBINCompiler download first — it puts the 'mbincompiler' command on your PATH — then try again." buttons {"OK"} default button "OK" with icon stop with title "MBINCompiler"
		error number -128 -- quietly abort
	end try
end findTool

on run
	-- Double-clicked instead of dropped onto.
	display dialog "Drag .MBIN or .MXML files onto this app icon to convert them." & return & return & "MBIN → MXML and MXML → MBIN are detected automatically, and the result is written next to each source file." buttons {"OK"} default button "OK" with title "MBINCompiler"
end run

on open theFiles
	set tool to findTool()
	set okCount to 0
	set failures to {}
	repeat with f in theFiles
		set p to POSIX path of f
		try
			do shell script quoted form of tool & " -y -f " & quoted form of p
			set okCount to okCount + 1
		on error errMsg
			set end of failures to p & " — " & errMsg
		end try
	end repeat
	if (count of failures) = 0 then
		display notification ((okCount as text) & " file(s) converted.") with title "MBINCompiler"
	else
		set msg to (okCount as text) & " converted, " & (count of failures as text) & " failed:" & return & return
		repeat with oneFailure in failures
			set msg to msg & oneFailure & return
		end repeat
		display dialog msg buttons {"OK"} default button "OK" with icon caution with title "MBINCompiler"
	end if
end open
