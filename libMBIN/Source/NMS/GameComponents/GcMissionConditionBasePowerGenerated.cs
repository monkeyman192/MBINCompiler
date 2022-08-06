using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AFD4FA710102517, NameHash = 0x957DDD469FE6A35C)]
    public class GcMissionConditionBasePowerGenerated : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        /* 0x4 */ public bool MustBeSpare;
        /* 0x5 */ public bool TakeAmountFromSeasonData;
    }
}
