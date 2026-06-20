import SwiftUI

@main
struct MBINCompilerGUIApp: App {
    @State private var model = AppModel()

    var body: some Scene {
        WindowGroup("MBINCompiler") {
            ContentView()
                .environment(model)
                .frame(minWidth: 580, minHeight: 560)
        }
        .windowResizability(.contentMinSize)
    }
}
