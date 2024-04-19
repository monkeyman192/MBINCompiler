using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3990C837CE0F70A1, NameHash = 0x11A53087B029E4F)]
    public class GcGeneratedBaseRoomTemplate : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour QuaternaryColour;
        /* 0x20 */ public Colour SecondaryColour;
        /* 0x30 */ public Colour TernaryColour;
        /* 0x40 */ public NMSString0x20A LocId;
        /* 0x60 */ public List<NMSString0x10> DecorationThemes;
        /* 0x70 */ public NMSString0x10 Name;
        /* 0x80 */ public int MaxPathLength;
        /* 0x84 */ public int MinContiguousDepth;
        /* 0x88 */ public int MinContiguousHeight;
        /* 0x8C */ public int MinContiguousWidth;
        /* 0x90 */ public int MinPathLength;
        /* 0x94 */ public float ShrinkFactor;
    }
}
