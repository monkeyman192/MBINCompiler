using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x959EEF00D2B6816B, NameHash = 0x1C7BDD4B8265FAA3)]
    public class GcMissionConditionTakingDamage : NMSTemplate
    {
        /* 0x0 */ public bool RequireShieldDown;
        /* 0x8 */ public NMSString0x10 DamageID;
    }
}
