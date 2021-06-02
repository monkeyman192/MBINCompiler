using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, GUID = 0x1BA1389948946EA6, NameHash = 0xB24FD22ADB1D885D)]
    public class GcGalaxyMarkerSettings : NMSTemplate
    {
        [NMS(Size = 3)]
        /* 0x00 */ public Colour[] Colours;

        /* 0x30 */ public Colour OutlineColour;
        /* 0x40 */ public float OutlineWidth;
        /* 0x44 */ public int EdgeCount;
        /* 0x48 */ public float RotationBase;
        /* 0x4C */ public float LineWidth;
        /* 0x50 */ public float LineWidthFade;
        /* 0x54 */ public float SizeScale;
        /* 0x58 */ public float RadiusFixed;
        /* 0x5C */ public float RadiusMinimum;
        /* 0x60 */ public float RadiusBaseOffset;
        /* 0x64 */ public float RadiusEdge;
        /* 0x68 */ public NMSString0x80 Icon;
        /* 0xE8 */ public Vector2f IconSize;
        /* 0xF0 */ public NMSString0x20 MarkerLabel;
        /* 0x110 */ public Vector2f TimeScaleRange;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x118 */ public byte[] EndPadding;
    }
}
