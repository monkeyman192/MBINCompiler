using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BC12477CF28B5FF, NameHash = 0xA810AAF8)]
    public class Mapping : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<InfluencesOnMappedPoint> InfluencesOnMappedPoint;
        [NMS(Index = 3)]
        /* 0x10 */ public int NumMappedPoints;
        [NMS(Index = 1)]
        /* 0x14 */ public int NumSimI;
        [NMS(Index = 2)]
        /* 0x18 */ public int NumSimJ;
        [NMS(Index = 0)]
        /* 0x1C */ public NMSString0x40 Name;
    }
}
