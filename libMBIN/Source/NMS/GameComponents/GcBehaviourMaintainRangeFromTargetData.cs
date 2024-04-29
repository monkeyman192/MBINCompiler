using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAE948C2EEF3486F, NameHash = 0x7C8B3A3A3EEFC49F)]
    public class GcBehaviourMaintainRangeFromTargetData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkBlackboardDefaultValueFloat MaxDist;
        [NMS(Index = 1)]
        /* 0x18 */ public TkBlackboardDefaultValueFloat MinDist;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 TargetKey;
        [NMS(Index = 6)]
        /* 0x40 */ public float AvoidCreaturesStrength;
        [NMS(Index = 5)]
        /* 0x44 */ public float SpeedModifier;
        [NMS(Index = 3)]
        /* 0x48 */ public bool _2D;
        [NMS(Index = 4)]
        /* 0x49 */ public bool SucceedWhenInRange;
    }
}
