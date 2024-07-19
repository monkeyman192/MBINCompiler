using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1EA87CB90C440AD, NameHash = 0xF0DC22E6)]
    public class SimShape : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public List<ShapePoint> ShapePoints;
        [NMS(Index = 1)]
        /* 0x10 */ public int NumSimI;
        [NMS(Index = 2)]
        /* 0x14 */ public int NumSimJ;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x40 Name;
        [NMS(Index = 5)]
        /* 0x58 */ public bool SimPIsInUnwrappedFormat;
        [NMS(Index = 3)]
        /* 0x59 */ public bool WrapI;
        [NMS(Index = 4)]
        /* 0x5A */ public bool WrapJ;
    }
}
