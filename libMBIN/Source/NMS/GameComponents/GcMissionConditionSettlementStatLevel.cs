using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB22A7DF308235AC, NameHash = 0x1DD776B0B61E916)]
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
