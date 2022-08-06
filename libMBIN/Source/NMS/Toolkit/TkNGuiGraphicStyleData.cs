namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF37ACDDBA9FD878F, NameHash = 0x250B60FD6373D170)]
    public class TkNGuiGraphicStyleData : NMSTemplate
    {
        /* 0x00 */ public float PaddingX;
        /* 0x04 */ public float PaddingY;
        /* 0x08 */ public float MarginX;
        /* 0x0C */ public float MarginY;
        /* 0x10 */ public Colour Colour;
        /* 0x20 */ public Colour IconColour;
        /* 0x30 */ public Colour StrokeColour;
        // size: 0x8
        public enum ShapeEnum {
            Rectangle,
            Ellipse,
            Line,
            LineInverted,
            Bezier,
            BezierInverted,
            BezierWide,
            BezierWideInverted
        }
        /* 0x40 */ public ShapeEnum Shape;
        /* 0x44 */ public bool SolidColour;
        /* 0x45 */ public bool HasDropShadow;
        /* 0x46 */ public bool HasOuterGradient;
        /* 0x47 */ public bool HasInnerGradient;
        // size: 0x6
        public enum GradientEnum {
            None,
            Vertical,
            Horizontal,
            HorizontalBounce,
            Radial,
            Box
        }
        /* 0x48 */ public GradientEnum Gradient;
        /* 0x4C */ public float GradientStartOffset;
        /* 0x50 */ public float GradientEndOffset;
        /* 0x54 */ public bool GradientOffsetPercent;
        /* 0x60 */ public Colour GradientColour;
        /* 0x70 */ public float CornerRadius;
        /* 0x74 */ public float StrokeSize;
        /* 0x78 */ public int Image;
        /* 0x7C */ public int Icon;
        /* 0x80 */ public float Desaturation;
        /* 0x84 */ public bool StrokeGradient;
        /* 0x88 */ public float StrokeGradientOffset;
        /* 0x8C */ public float StrokeGradientFeather;
        /* 0x90 */ public Colour StrokeGradientColour;
    }
}
