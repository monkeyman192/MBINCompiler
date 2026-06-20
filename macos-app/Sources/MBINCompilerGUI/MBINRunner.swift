import Foundation

/// Locates and runs the .NET MBINCompiler binary that is bundled inside the
/// app, streaming its combined stdout/stderr back as it arrives.
enum MBINRunner {
    /// The bundled binary lives at `Contents/Resources/mbincompiler/MBINCompiler`.
    /// When running from `swift run` during development there is no bundle, so we
    /// also honour the `MBINCOMPILER_BIN` environment variable.
    static func locateBinary() -> URL? {
        let fm = FileManager.default
        if let resources = Bundle.main.resourceURL {
            let bundled = resources.appendingPathComponent("mbincompiler/MBINCompiler")
            if fm.isExecutableFile(atPath: bundled.path) { return bundled }
        }
        if let override = ProcessInfo.processInfo.environment["MBINCOMPILER_BIN"],
           fm.isExecutableFile(atPath: override) {
            return URL(fileURLWithPath: override)
        }
        return nil
    }

    /// Runs the binary and returns its exit code. `onOutput` is always delivered
    /// on the main thread, in order.
    static func run(binary: URL, arguments: [String], onOutput: @escaping (String) -> Void) async -> Int32 {
        await withCheckedContinuation { continuation in
            DispatchQueue.global(qos: .userInitiated).async {
                let process = Process()
                process.executableURL = binary
                process.arguments = arguments
                process.currentDirectoryURL = binary.deletingLastPathComponent()

                let pipe = Pipe()
                process.standardOutput = pipe
                process.standardError = pipe
                process.standardInput = FileHandle.nullDevice   // never block on a prompt

                do {
                    try process.run()
                } catch {
                    DispatchQueue.main.async {
                        onOutput("Failed to launch MBINCompiler: \(error.localizedDescription)\n")
                    }
                    continuation.resume(returning: -1)
                    return
                }

                let handle = pipe.fileHandleForReading
                while true {
                    let data = handle.availableData
                    if data.isEmpty { break }   // EOF
                    if let text = String(data: data, encoding: .utf8) {
                        DispatchQueue.main.async { onOutput(text) }
                    }
                }

                process.waitUntilExit()
                continuation.resume(returning: process.terminationStatus)
            }
        }
    }
}
