namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EC7B722797A2056, NameHash = 0xCF5A623A)]
    public class GcCreatureFootParticleSingleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 EffectName;
        [NMS(Index = 3)]
        /* 0x10 */ public float MaxCreatureSize;
        [NMS(Index = 2)]
        /* 0x14 */ public float MinCreatureSize;
        // size: 0x3
        public enum MoveSpeedEnum : uint {
            Always,
            Walk,
            Run,
        }
        [NMS(Index = 4)]
        /* 0x18 */ public MoveSpeedEnum MoveSpeed;
        [NMS(Index = 1)]
        /* 0x1C */ public float Scale;
    }
}
