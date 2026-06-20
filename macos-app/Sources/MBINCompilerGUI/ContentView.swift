import SwiftUI
import AppKit
import UniformTypeIdentifiers

struct ContentView: View {
    @Environment(AppModel.self) private var model
    @State private var dropTargeted = false

    var body: some View {
        @Bindable var model = model
        VStack(spacing: 14) {
            if !model.binaryFound {
                Label("Bundled MBINCompiler binary not found — reinstall with ./install_mac_gui",
                      systemImage: "exclamationmark.triangle.fill")
                    .font(.callout)
                    .foregroundStyle(.orange)
                    .frame(maxWidth: .infinity, alignment: .leading)
            }

            dropZone
            optionsPanel
            outputConsole
        }
        .padding(16)
    }

    // MARK: Drop zone

    private var dropZone: some View {
        VStack(spacing: 8) {
            Image(systemName: "arrow.down.doc.fill")
                .font(.system(size: 34))
                .foregroundStyle(.tint)
            Text("Drag .MBIN or .MXML files here")
                .font(.headline)
            Text("MBIN → MXML and MXML → MBIN are detected automatically")
                .font(.caption)
                .foregroundStyle(.secondary)
            Button("Choose Files…", action: chooseFiles)
                .padding(.top, 2)
        }
        .frame(maxWidth: .infinity)
        .padding(.vertical, 24)
        .background(
            RoundedRectangle(cornerRadius: 12)
                .fill(dropTargeted ? Color.accentColor.opacity(0.12) : Color(nsColor: .underPageBackgroundColor))
        )
        .overlay(
            RoundedRectangle(cornerRadius: 12)
                .strokeBorder(dropTargeted ? Color.accentColor : Color.secondary.opacity(0.4),
                              style: StrokeStyle(lineWidth: 1.5, dash: [6]))
        )
        .dropDestination(for: URL.self) { urls, _ in
            model.process(urls: urls)
            return true
        } isTargeted: { dropTargeted = $0 }
    }

    // MARK: Options

    private var optionsPanel: some View {
        @Bindable var model = model
        return GroupBox("Options") {
            Grid(alignment: .leading, horizontalSpacing: 16, verticalSpacing: 10) {
                GridRow {
                    Text("If a file exists")
                    Picker("", selection: $model.overwrite) {
                        ForEach(OverwriteMode.allCases) { Text($0.rawValue).tag($0) }
                    }
                    .pickerStyle(.segmented)
                    .labelsHidden()
                }
                GridRow {
                    Text("Output format")
                    Picker("", selection: $model.outputFormat) {
                        ForEach(OutputFormat.allCases) { Text($0.rawValue).tag($0) }
                    }
                    .pickerStyle(.segmented)
                    .labelsHidden()
                }
                GridRow {
                    Text("Flags")
                    HStack(spacing: 16) {
                        Toggle("Skip errors", isOn: $model.force)
                        Toggle("Typed MXML", isOn: $model.typed)
                        Toggle("No version header", isOn: $model.noVersion)
                    }
                }
                GridRow {
                    Text("")
                    HStack(spacing: 16) {
                        Toggle("Quiet", isOn: $model.quiet)
                        Toggle("No log file", isOn: $model.noLog)
                    }
                }
                GridRow {
                    Text("Output to")
                    HStack {
                        Text(model.outputDirectory?.path ?? "Alongside each source file")
                            .foregroundStyle(model.outputDirectory == nil ? .secondary : .primary)
                            .lineLimit(1)
                            .truncationMode(.middle)
                        Spacer()
                        Button("Choose…", action: chooseOutputDirectory)
                        if model.outputDirectory != nil {
                            Button("Reset") { model.outputDirectory = nil }
                        }
                    }
                }
            }
            .padding(6)
        }
    }

    // MARK: Output console

    private var outputConsole: some View {
        GroupBox {
            ScrollViewReader { proxy in
                ScrollView {
                    Text(model.output.isEmpty ? "Output will appear here." : model.output)
                        .font(.system(.caption, design: .monospaced))
                        .foregroundStyle(model.output.isEmpty ? .secondary : .primary)
                        .textSelection(.enabled)
                        .frame(maxWidth: .infinity, alignment: .leading)
                        .padding(8)
                    Color.clear.frame(height: 1).id("bottom")
                }
                .frame(minHeight: 180)
                .onChange(of: model.output) {
                    withAnimation { proxy.scrollTo("bottom", anchor: .bottom) }
                }
            }
        } label: {
            HStack {
                Text("Output")
                if model.isRunning {
                    ProgressView().controlSize(.small).padding(.leading, 4)
                }
                Spacer()
                Button("Copy", action: copyOutput).disabled(model.output.isEmpty)
                Button("Clear") { model.clear() }.disabled(model.output.isEmpty)
            }
        }
    }

    // MARK: Actions

    private func chooseFiles() {
        let panel = NSOpenPanel()
        panel.canChooseFiles = true
        panel.canChooseDirectories = true
        panel.allowsMultipleSelection = true
        if panel.runModal() == .OK { model.process(urls: panel.urls) }
    }

    private func chooseOutputDirectory() {
        let panel = NSOpenPanel()
        panel.canChooseFiles = false
        panel.canChooseDirectories = true
        panel.canCreateDirectories = true
        panel.allowsMultipleSelection = false
        if panel.runModal() == .OK { model.outputDirectory = panel.url }
    }

    private func copyOutput() {
        NSPasteboard.general.clearContents()
        NSPasteboard.general.setString(model.output, forType: .string)
    }
}
