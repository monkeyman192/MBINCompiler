namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D337FA7A210A1B8, NameHash = 0xB24FD22ADB1D885D)]
    public class GcGalaxyMarkerSettings : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x00 */ public Colour[] Colours;
        /* 0x30 */ public Colour OutlineColour;
        /* 0x40 */ public Vector2f IconSize;
        /* 0x48 */ public Vector2f TimeScaleRange;
        /* 0x50 */ public int EdgeCount;
        /* 0x54 */ public float LineWidth;
        /* 0x58 */ public float LineWidthFade;
        /* 0x5C */ public float OutlineWidth;
        /* 0x60 */ public float RadiusBaseOffset;
        /* 0x64 */ public float RadiusEdge;
        /* 0x68 */ public float RadiusFixed;
        /* 0x6C */ public float RadiusMinimum;
        /* 0x70 */ public float RotationBase;
        /* 0x74 */ public float SizeScale;
        /* 0x78 */ public NMSString0x80 Icon;
        /* 0xF8 */ public NMSString0x20 MarkerLabel;
    }
}
