// Generates the MBINCompiler app icon — a binary ⇄ markup "transform" glyph on a
// deep-space card, evoking No Man's Sky .MBIN ↔ .MXML conversion.
// Reproducible: pure CoreGraphics, deterministic. Run:  swift GenerateIcon.swift out.png
import CoreGraphics
import ImageIO
import Foundation
import UniformTypeIdentifiers

let S = 1024
let cs = CGColorSpaceCreateDeviceRGB()
guard let ctx = CGContext(data: nil, width: S, height: S, bitsPerComponent: 8, bytesPerRow: 0,
                          space: cs, bitmapInfo: CGImageAlphaInfo.premultipliedLast.rawValue) else { fatalError() }
ctx.setShouldAntialias(true)
let sz = CGFloat(S)

func cg(_ r: CGFloat, _ g: CGFloat, _ b: CGFloat, _ a: CGFloat) -> CGColor { CGColor(colorSpace: cs, components: [r, g, b, a])! }

// Rounded-rect "card".
let margin: CGFloat = 100
let card = CGRect(x: margin, y: margin, width: sz - 2 * margin, height: sz - 2 * margin)
let cardPath = CGPath(roundedRect: card, cornerWidth: 185, cornerHeight: 185, transform: nil)

ctx.saveGState()
ctx.addPath(cardPath); ctx.clip()
// NMS-ish deep teal → near-black, with a warm amber core glow.
let bg = CGGradient(colorsSpace: cs, colors: [cg(0.05, 0.22, 0.26, 1), cg(0.02, 0.03, 0.05, 1)] as CFArray, locations: [0, 1])!
ctx.drawLinearGradient(bg, start: CGPoint(x: 0, y: sz), end: CGPoint(x: sz, y: 0), options: [])
let center = CGPoint(x: sz / 2, y: sz / 2)
let core = CGGradient(colorsSpace: cs, colors: [cg(1, 0.6, 0.2, 0.35), cg(1, 0.6, 0.2, 0)] as CFArray, locations: [0, 1])!
ctx.drawRadialGradient(core, startCenter: center, startRadius: 0, endCenter: center, endRadius: sz * 0.42, options: [])

let amber = cg(1.0, 0.72, 0.28, 1)
let teal = cg(0.4, 0.9, 0.85, 1)

// Left: stacked binary "bits" (MBIN, the binary side).
ctx.setFillColor(teal)
let bitW: CGFloat = 46, bitH: CGFloat = 46, gap: CGFloat = 20
let rows: [[Int]] = [[1,0,1,0],[0,1,1,0],[1,1,0,1]]
let blockW = CGFloat(4) * bitW + 3 * gap
let startX = sz * 0.30 - blockW / 2
let startY = center.y + (CGFloat(rows.count) * (bitH + gap) - gap) / 2 - bitH
for (r, row) in rows.enumerated() {
    for (c, bit) in row.enumerated() {
        let x = startX + CGFloat(c) * (bitW + gap)
        let y = startY - CGFloat(r) * (bitH + gap)
        let rect = CGRect(x: x, y: y, width: bitW, height: bitH)
        let p = CGPath(roundedRect: rect, cornerWidth: 10, cornerHeight: 10, transform: nil)
        ctx.addPath(p)
        if bit == 1 { ctx.setFillColor(teal); ctx.fillPath() }
        else { ctx.setStrokeColor(cg(0.4, 0.9, 0.85, 0.55)); ctx.setLineWidth(6); ctx.strokePath() }
    }
}

// Right: angle brackets </> (MXML, the markup side).
ctx.setStrokeColor(amber); ctx.setLineWidth(34); ctx.setLineCap(.round); ctx.setLineJoin(.round)
let rx = sz * 0.70, ry = center.y, reach: CGFloat = 90, half: CGFloat = 95
ctx.move(to: CGPoint(x: rx - 30, y: ry + half))   // '<'
ctx.addLine(to: CGPoint(x: rx - 30 - reach, y: ry))
ctx.addLine(to: CGPoint(x: rx - 30, y: ry - half))
ctx.strokePath()
ctx.move(to: CGPoint(x: rx + 30, y: ry + half))   // '>'
ctx.addLine(to: CGPoint(x: rx + 30 + reach, y: ry))
ctx.addLine(to: CGPoint(x: rx + 30, y: ry - half))
ctx.strokePath()

// Central bidirectional transform arrows linking the two.
ctx.setStrokeColor(cg(1, 1, 1, 0.92)); ctx.setLineWidth(22)
func arrow(y: CGFloat, pointLeft: Bool) {
    let x0 = center.x - 70, x1 = center.x + 70
    ctx.move(to: CGPoint(x: x0, y: y)); ctx.addLine(to: CGPoint(x: x1, y: y)); ctx.strokePath()
    let tip = pointLeft ? CGPoint(x: x0, y: y) : CGPoint(x: x1, y: y)
    let dir: CGFloat = pointLeft ? 1 : -1
    ctx.move(to: CGPoint(x: tip.x + dir * 34, y: y + 26))
    ctx.addLine(to: tip); ctx.addLine(to: CGPoint(x: tip.x + dir * 34, y: y - 26)); ctx.strokePath()
}
arrow(y: center.y + 34, pointLeft: false)
arrow(y: center.y - 34, pointLeft: true)
ctx.restoreGState()

// Faint rim for definition.
ctx.addPath(cardPath); ctx.setStrokeColor(cg(1, 1, 1, 0.07)); ctx.setLineWidth(2); ctx.strokePath()

guard let img = ctx.makeImage() else { fatalError() }
let out = URL(fileURLWithPath: CommandLine.arguments.count > 1 ? CommandLine.arguments[1] : "icon_1024.png")
guard let dest = CGImageDestinationCreateWithURL(out as CFURL, UTType.png.identifier as CFString, 1, nil) else { fatalError() }
CGImageDestinationAddImage(dest, img, nil)
CGImageDestinationFinalize(dest)
print("wrote \(out.path)")
