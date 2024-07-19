using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB0B8391DE28A687, NameHash = 0x3B7F583E)]
    public class GcMissionConditionSettlementStatLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float NormalisedLevel;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSettlementStatType Stat;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
