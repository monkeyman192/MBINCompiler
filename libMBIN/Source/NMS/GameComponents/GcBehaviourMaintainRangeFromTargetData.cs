using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8959480696CF2F28, NameHash = 0x7C8B3A3A3EEFC49F)]
    public class GcBehaviourMaintainRangeFromTargetData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueFloat MaxDist;
        /* 0x18 */ public TkBlackboardDefaultValueFloat MinDist;
        /* 0x30 */ public NMSString0x10 TargetKey;
        /* 0x40 */ public float AvoidCreaturesStrength;
        /* 0x44 */ public float SpeedModifier;
        /* 0x48 */ public bool _2D;
        /* 0x49 */ public bool SucceedWhenInRange;
    }
}
