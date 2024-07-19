using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39C73E477F6AF6C8, NameHash = 0x7FC50AF8)]
    public class GcStatRewardGroup : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A LocIDMultiple;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A LocIDSingle;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 ID;
        [NMS(Index = 6)]
        /* 0x68 */ public List<GcStatRewardGroupStatData> Stats;
        [NMS(Index = 5)]
        /* 0x78 */ public float BaseMultiplier;
        [NMS(Index = 4)]
        /* 0x7C */ public GcCurrency Currency;
    }
}
