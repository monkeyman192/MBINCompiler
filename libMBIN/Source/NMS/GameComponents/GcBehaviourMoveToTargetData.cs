using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0FEA729BCF5CF2, NameHash = 0x6E681E32)]
    public class GcBehaviourMoveToTargetData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkBlackboardDefaultValueFloat ArriveDist;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 TargetKey;
        [NMS(Index = 5)]
        /* 0x28 */ public float AvoidCreaturesStrength;
        // size: 0x3
        public enum BehaviourMoveSpeedEnum : uint {
            Normal,
            Fast,
            Dynamic,
        }
        [NMS(Index = 2)]
        /* 0x2C */ public BehaviourMoveSpeedEnum BehaviourMoveSpeed;
        [NMS(Index = 3)]
        /* 0x30 */ public float DynamicMoveSlowdownDistMul;
        [NMS(Index = 4)]
        /* 0x34 */ public float SpeedModifier;
    }
}
