using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DA83E2A2F37C5B5, NameHash = 0xCCEFDDFB7EC30619)]
    public class GcStatRewardGroup : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A LocIDMultiple;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A LocIDSingle;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 ID;
        [NMS(Index = 6)]
        /* 0x50 */ public List<GcStatRewardGroupStatData> Stats;
        [NMS(Index = 3)]
        /* 0x60 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0xE4 */ public float BaseMultiplier;
        [NMS(Index = 4)]
        /* 0xE8 */ public GcCurrency Currency;
    }
}
