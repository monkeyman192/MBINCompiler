using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA0, GUID = 0x5A308E9F9F73E5EC, Alignment = 0x10, NameHash = 0x250B60FD6373D170)]
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
		/* 0x40 */ public ShapeEnum Shape;


        /* 0x44 */ public bool SolidColour;
        /* 0x45 */ public bool HasDropShadow;
        /* 0x46 */ public bool HasOuterGradient;
        /* 0x47 */ public bool HasInnerGradient;

		public enum GradientEnum { None, Vertical, Horizontal, HorizontalBounce, Radial, Box }
		/* 0x48 */ public GradientEnum Gradient;


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
        /* 0x80 */ public bool StrokeGradient;
        /* 0x84 */ public float StrokeGradientOffset;
        /* 0x88 */ public float StrokeGradientFeather;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x8C */ public byte[] Padding8C;
        /* 0x90 */ public Colour StrokeGradientColour;
    }
}
