namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3057EBBE13660E09, NameHash = 0xB24FD22ADB1D885D)]
    public class GcGalaxyMarkerSettings : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3)]
        /* 0x00 */ public Colour[] Colours;
        [NMS(Index = 1)]
        /* 0x30 */ public Colour OutlineColour;
        [NMS(Index = 13)]
        /* 0x40 */ public Vector2f IconSize;
        [NMS(Index = 15)]
        /* 0x48 */ public Vector2f TimeScaleRange;
        [NMS(Index = 3)]
        /* 0x50 */ public int EdgeCount;
        [NMS(Index = 5)]
        /* 0x54 */ public float LineWidth;
        [NMS(Index = 6)]
        /* 0x58 */ public float LineWidthFade;
        [NMS(Index = 2)]
        /* 0x5C */ public float OutlineWidth;
        [NMS(Index = 10)]
        /* 0x60 */ public float RadiusBaseOffset;
        [NMS(Index = 11)]
        /* 0x64 */ public float RadiusEdge;
        [NMS(Index = 8)]
        /* 0x68 */ public float RadiusFixed;
        [NMS(Index = 9)]
        /* 0x6C */ public float RadiusMinimum;
        [NMS(Index = 4)]
        /* 0x70 */ public float RotationBase;
        [NMS(Index = 7)]
        /* 0x74 */ public float SizeScale;
        [NMS(Index = 12)]
        /* 0x78 */ public NMSString0x80 Icon;
        [NMS(Index = 14)]
        /* 0xF8 */ public NMSString0x20 MarkerLabel;
    }
}
