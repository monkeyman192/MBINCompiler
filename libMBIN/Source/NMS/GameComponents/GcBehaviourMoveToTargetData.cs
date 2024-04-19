using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48738CDF0B50AEFB, NameHash = 0x6CCA924D787E12E)]
    public class GcBehaviourMoveToTargetData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueFloat ArriveDist;
        /* 0x18 */ public NMSString0x10 TargetKey;
        /* 0x28 */ public float AvoidCreaturesStrength;
        // size: 0x3
        public enum BehaviourMoveSpeedEnum : uint {
            Normal,
            Fast,
            Dynamic,
        }
        /* 0x2C */ public BehaviourMoveSpeedEnum BehaviourMoveSpeed;
        /* 0x30 */ public float DynamicMoveSlowdownDistMul;
        /* 0x34 */ public float SpeedModifier;
    }
}
