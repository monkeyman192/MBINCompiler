namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x552535F91EFFB020, NameHash = 0x250B60FD6373D170)]
    public class TkNGuiGraphicStyleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 3)]
        /* 0x10 */ public Colour GradientColour;
        [NMS(Index = 1)]
        /* 0x20 */ public Colour IconColour;
        [NMS(Index = 2)]
        /* 0x30 */ public Colour StrokeColour;
        [NMS(Index = 4)]
        /* 0x40 */ public Colour StrokeGradientColour;
        [NMS(Index = 11)]
        /* 0x50 */ public float CornerRadius;
        [NMS(Index = 15)]
        /* 0x54 */ public float Desaturation;
        [NMS(Index = 10)]
        /* 0x58 */ public float GradientEndOffset;
        [NMS(Index = 9)]
        /* 0x5C */ public float GradientStartOffset;
        [NMS(Index = 14)]
        /* 0x60 */ public int Icon;
        [NMS(Index = 13)]
        /* 0x64 */ public int Image;
        [NMS(Index = 7)]
        /* 0x68 */ public float MarginX;
        [NMS(Index = 8)]
        /* 0x6C */ public float MarginY;
        [NMS(Index = 5)]
        /* 0x70 */ public float PaddingX;
        [NMS(Index = 6)]
        /* 0x74 */ public float PaddingY;
        [NMS(Index = 17)]
        /* 0x78 */ public float StrokeGradientFeather;
        [NMS(Index = 16)]
        /* 0x7C */ public float StrokeGradientOffset;
        [NMS(Index = 12)]
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
        [NMS(Index = 19)]
        /* 0x84 */ public GradientEnum Gradient;
        [NMS(Index = 24)]
        /* 0x85 */ public bool GradientOffsetPercent;
        [NMS(Index = 21)]
        /* 0x86 */ public bool HasDropShadow;
        [NMS(Index = 23)]
        /* 0x87 */ public bool HasInnerGradient;
        [NMS(Index = 22)]
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
        [NMS(Index = 18)]
        /* 0x89 */ public ShapeEnum Shape;
        [NMS(Index = 20)]
        /* 0x8A */ public bool SolidColour;
        [NMS(Index = 25)]
        /* 0x8B */ public bool StrokeGradient;
    }
}
