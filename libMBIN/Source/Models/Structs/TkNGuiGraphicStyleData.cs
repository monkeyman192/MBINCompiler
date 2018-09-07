namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x80)]
    public class TkNGuiGraphicStyleData : NMSTemplate
    {
        /* 0x00 */ public float PaddingX;
        /* 0x04 */ public float PaddingY;
        /* 0x08 */ public float MarginX;
        /* 0x0C */ public float MarginY;
        /* 0x10 */ public Colour Colour;
        /* 0x20 */ public Colour IconColour;
        /* 0x30 */ public Colour StrokeColour;

		public enum ShapeEnum { Rectangle, Ellipse }
		public ShapeEnum Shape;


        /* 0x44 */ public bool SolidColour;
        /* 0x45 */ public bool HasDropShadow;
        /* 0x46 */ public bool HasOuterGradient;
        /* 0x47 */ public bool HasInnerGradient;

		public enum GradientEnum { None, Vertical, Horizontal, HorizontalBounce }
		public GradientEnum Gradient;


        /* 0x4C */ public float GradientStartOffset;
        /* 0x50 */ public float GradientEndOffset;
        /* 0x54 */ public bool GradientOffsetPercent;

        [NMS(Size = 0xB, Ignore = true)]
        /* 0x55 */ public byte[] Padding55;

        /* 0x60 */ public Colour GradientColour;
        /* 0x70 */ public float CornerRadius;
        /* 0x74 */ public float StrokeSize;
        /* 0x78 */ public int Image;
        /* 0x7C */ public int Icon;
    }
}
