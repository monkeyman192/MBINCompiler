using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x778F5AA5C6774EF3, NameHash = 0x93482A51)]
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
        [NMS(Index = 26)]
        /* 0x50 */ public TkNGuiGraphicAnimatedImageData Animated;
        [NMS(Index = 11)]
        /* 0x64 */ public float CornerRadius;
        [NMS(Index = 15)]
        /* 0x68 */ public float Desaturation;
        [NMS(Index = 14)]
        /* 0x6C */ public TkNGuiEditorIcons EditorIcon;
        [NMS(Index = 10)]
        /* 0x70 */ public float GradientEndOffset;
        [NMS(Index = 9)]
        /* 0x74 */ public float GradientStartOffset;
        [NMS(Index = 13)]
        /* 0x78 */ public int Image;
        [NMS(Index = 7)]
        /* 0x7C */ public float MarginX;
        [NMS(Index = 8)]
        /* 0x80 */ public float MarginY;
        [NMS(Index = 5)]
        /* 0x84 */ public float PaddingX;
        [NMS(Index = 6)]
        /* 0x88 */ public float PaddingY;
        [NMS(Index = 17)]
        /* 0x8C */ public float StrokeGradientFeather;
        [NMS(Index = 16)]
        /* 0x90 */ public float StrokeGradientOffset;
        [NMS(Index = 12)]
        /* 0x94 */ public float StrokeSize;
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
        /* 0x98 */ public GradientEnum Gradient;
        [NMS(Index = 24)]
        /* 0x99 */ public bool GradientOffsetPercent;
        [NMS(Index = 21)]
        /* 0x9A */ public bool HasDropShadow;
        [NMS(Index = 23)]
        /* 0x9B */ public bool HasInnerGradient;
        [NMS(Index = 22)]
        /* 0x9C */ public bool HasOuterGradient;
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
        /* 0x9D */ public ShapeEnum Shape;
        [NMS(Index = 20)]
        /* 0x9E */ public bool SolidColour;
        [NMS(Index = 25)]
        /* 0x9F */ public bool StrokeGradient;
    }
}
