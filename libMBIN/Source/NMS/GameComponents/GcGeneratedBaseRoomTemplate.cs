using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5477500A8B879ED1, NameHash = 0x5F0A6CCE)]
    public class GcGeneratedBaseRoomTemplate : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour PrimaryColour;
        [NMS(Index = 5)]
        /* 0x10 */ public Colour QuaternaryColour;
        [NMS(Index = 3)]
        /* 0x20 */ public Colour SecondaryColour;
        [NMS(Index = 4)]
        /* 0x30 */ public Colour TernaryColour;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A LocId;
        [NMS(Index = 12)]
        /* 0x60 */ public List<NMSString0x10> DecorationThemes;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 Name;
        [NMS(Index = 7)]
        /* 0x80 */ public int MaxPathLength;
        [NMS(Index = 10)]
        /* 0x84 */ public int MinContiguousDepth;
        [NMS(Index = 9)]
        /* 0x88 */ public int MinContiguousHeight;
        [NMS(Index = 8)]
        /* 0x8C */ public int MinContiguousWidth;
        [NMS(Index = 6)]
        /* 0x90 */ public int MinPathLength;
        [NMS(Index = 11)]
        /* 0x94 */ public float ShrinkFactor;
    }
}
