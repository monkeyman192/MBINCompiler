namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90B7FF87196B15B6, NameHash = 0x8CD0B53079BD773C)]
    public class GcCreatureFootParticleSingleData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 EffectName;
        /* 0x10 */ public float MaxCreatureSize;
        /* 0x14 */ public float MinCreatureSize;
        // size: 0x3
        public enum MoveSpeedEnum : uint {
            Always,
            Walk,
            Run,
        }
        /* 0x18 */ public MoveSpeedEnum MoveSpeed;
        /* 0x1C */ public float Scale;
    }
}
