using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F4F88BBB72BE60, NameHash = 0x1DD776B0B61E916)]
    public class GcMissionConditionSettlementStatLevel : NMSTemplate
    {
        /* 0x0 */ public float NormalisedLevel;
        /* 0x4 */ public GcSettlementStatType Stat;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
