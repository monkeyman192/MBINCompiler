using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABC55F82D405E23E, NameHash = 0x11A53087B029E4F)]
    public class GcGeneratedBaseRoomTemplate : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public NMSString0x20A LocId;
        /* 0x30 */ public Colour PrimaryColour;
        /* 0x40 */ public Colour SecondaryColour;
        /* 0x50 */ public Colour TernaryColour;
        /* 0x60 */ public Colour QuaternaryColour;
        /* 0x70 */ public int MinPathLength;
        /* 0x74 */ public int MaxPathLength;
        /* 0x78 */ public int MinContiguousWidth;
        /* 0x7C */ public int MinContiguousHeight;
        /* 0x80 */ public int MinContiguousDepth;
        /* 0x84 */ public float ShrinkFactor;
        /* 0x88 */ public List<NMSString0x10> DecorationThemes;
    }
}
