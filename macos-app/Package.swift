// swift-tools-version: 5.9
// SwiftUI front-end for MBINCompiler. Built and bundled into a .app by the
// repo-root `./install_mac_gui` script.
import PackageDescription

let package = Package(
    name: "MBINCompilerGUI",
    platforms: [
        .macOS(.v14),
    ],
    targets: [
        .executableTarget(
            name: "MBINCompilerGUI",
            path: "Sources/MBINCompilerGUI"
        ),
    ]
)
