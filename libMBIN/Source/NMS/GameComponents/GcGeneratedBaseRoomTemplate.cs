using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, Alignment = 0x10, GUID = 0x590CDDA0790B637E, NameHash = 0x11A53087B029E4F)]
    public class GcGeneratedBaseRoomTemplate : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string LocId;
        /* 0x30 */ public Colour PrimaryColour;
        /* 0x40 */ public Colour SecondaryColour;
        /* 0x50 */ public int MinPathLength;
        /* 0x54 */ public int MaxPathLength;
        /* 0x58 */ public int MinContiguousWidth;
        /* 0x5C */ public int MinContiguousHeight;
        /* 0x60 */ public int MinContiguousDepth;
        /* 0x64 */ public float ShrinkFactor;
        /* 0x68 */ public List<NMSString0x10> DecorationThemes;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x78 */ public byte[] EndPadding;
    }
}
