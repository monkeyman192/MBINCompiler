import Foundation
import Observation

enum OverwriteMode: String, CaseIterable, Identifiable {
    case overwrite = "Overwrite existing"
    case keep = "Keep existing"
    var id: String { rawValue }
    /// Always pass an explicit choice so the CLI never blocks on its interactive
    /// "File already exists! Overwrite?" prompt (it would hang with no stdin).
    var flag: String { self == .overwrite ? "-y" : "-n" }
}

enum OutputFormat: String, CaseIterable, Identifiable {
    case auto = "Auto"
    case mbin = "MBIN"
    case mxml = "MXML"
    case exml = "EXML"
    var id: String { rawValue }
    var flags: [String] { self == .auto ? [] : ["-o", rawValue] }
}

@MainActor
@Observable
final class AppModel {
    // Options surfaced as toggles in the UI.
    var overwrite: OverwriteMode = .overwrite
    var outputFormat: OutputFormat = .auto
    var force = true            // skip files with errors and keep going
    var typed = false           // include type info in MXML
    var noVersion = false       // hide the MBINCompiler version in the MXML header
    var quiet = false           // suppress per-file console chatter
    var noLog = false           // don't write MBINCompiler.log next to the files
    var outputDirectory: URL?   // nil → write alongside each source file

    // Output console state.
    private(set) var output = ""
    private(set) var isRunning = false

    /// Where the bundled .NET binary lives, or nil if it can't be found.
    var binaryURL: URL? { MBINRunner.locateBinary() }
    var binaryFound: Bool { binaryURL != nil }

    func clear() { output = "" }

    private func append(_ text: String) {
        output += text
        if !output.hasSuffix("\n") { output += "\n" }
    }

    /// Build the option arguments (everything except the input paths).
    private func optionArguments() -> [String] {
        var args = [overwrite.flag]
        args += outputFormat.flags
        if force { args.append("-f") }
        if typed { args.append("--typed") }
        if noVersion { args.append("--no-version") }
        if quiet { args.append("-q") }
        if noLog { args.append("-Q") }
        if let dir = outputDirectory { args += ["-d", dir.path] }
        return args
    }

    func process(urls: [URL]) {
        let files = urls.filter { !$0.hasDirectoryPath } + urls.filter { $0.hasDirectoryPath }
        guard !files.isEmpty else { return }
        guard let binary = binaryURL else {
            append("⚠︎ Could not locate the bundled MBINCompiler binary.")
            append("   Reinstall with:  ./install_mac_gui")
            return
        }
        guard !isRunning else {
            append("⚠︎ Still working on the previous batch — try again in a moment.")
            return
        }

        isRunning = true
        let options = optionArguments()
        // With an explicit output directory the CLI only accepts one path at a
        // time, so fan the inputs out into separate invocations in that case.
        let invocations: [[String]] = outputDirectory == nil
            ? [options + files.map(\.path)]
            : files.map { options + [$0.path] }

        append("$ \(binary.lastPathComponent) \(options.joined(separator: " ")) \(files.map(\.lastPathComponent).joined(separator: " "))")

        Task {
            for args in invocations {
                let code = await MBINRunner.run(binary: binary, arguments: args) { [weak self] chunk in
                    self?.output += chunk
                }
                if code != 0 { append("\n[exit code \(code)]") }
            }
            append("✓ Done.")
            isRunning = false
        }
    }
}
