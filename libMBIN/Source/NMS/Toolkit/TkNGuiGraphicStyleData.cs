namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD456283B718F9F11, NameHash = 0x250B60FD6373D170)]
    public class TkNGuiGraphicStyleData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public Colour GradientColour;
        /* 0x20 */ public Colour IconColour;
        /* 0x30 */ public Colour StrokeColour;
        /* 0x40 */ public Colour StrokeGradientColour;
        /* 0x50 */ public float CornerRadius;
        /* 0x54 */ public float Desaturation;
        /* 0x58 */ public float GradientEndOffset;
        /* 0x5C */ public float GradientStartOffset;
        /* 0x60 */ public int Icon;
        /* 0x64 */ public int Image;
        /* 0x68 */ public float MarginX;
        /* 0x6C */ public float MarginY;
        /* 0x70 */ public float PaddingX;
        /* 0x74 */ public float PaddingY;
        /* 0x78 */ public float StrokeGradientFeather;
        /* 0x7C */ public float StrokeGradientOffset;
        /* 0x80 */ public float StrokeSize;
        // size: 0x6
        public enum GradientEnum : byte {
            None,
            Vertical,
            Horizontal,
            HorizontalBounce,
            Radial,
            Box,
        }
        /* 0x84 */ public GradientEnum Gradient;
        /* 0x85 */ public bool GradientOffsetPercent;
        /* 0x86 */ public bool HasDropShadow;
        /* 0x87 */ public bool HasInnerGradient;
        /* 0x88 */ public bool HasOuterGradient;
        // size: 0x8
        public enum ShapeEnum : byte {
            Rectangle,
            Ellipse,
            Line,
            LineInverted,
            Bezier,
            BezierInverted,
            BezierWide,
            BezierWideInverted,
        }
        /* 0x89 */ public ShapeEnum Shape;
        /* 0x8A */ public bool SolidColour;
        /* 0x8B */ public bool StrokeGradient;
    }
}
