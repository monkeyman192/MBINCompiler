namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4C80D8B834E42E5, NameHash = 0x566CA1D9F6501832)]
    public class GcCharacterLookAtData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float CreatureLookAtRadius;
        [NMS(Index = 0)]
        /* 0x04 */ public float InteractionLookAtRadius;
        [NMS(Index = 12)]
        /* 0x08 */ public float LookAtMaxPitch;
        [NMS(Index = 11)]
        /* 0x0C */ public float LookAtMaxYaw;
        [NMS(Index = 4)]
        /* 0x10 */ public float LookAtRunGlanceMaxTime;
        [NMS(Index = 3)]
        /* 0x14 */ public float LookAtRunGlanceMinTime;
        [NMS(Index = 6)]
        /* 0x18 */ public float LookAtRunMaxTime;
        [NMS(Index = 5)]
        /* 0x1C */ public float LookAtRunMinTime;
        [NMS(Index = 8)]
        /* 0x20 */ public float LookAtTargetGlanceMaxTime;
        [NMS(Index = 7)]
        /* 0x24 */ public float LookAtTargetGlanceMinTime;
        [NMS(Index = 10)]
        /* 0x28 */ public float LookAtTargetWaitMaxTime;
        [NMS(Index = 9)]
        /* 0x2C */ public float LookAtTargetWaitMinTime;
        [NMS(Index = 2)]
        /* 0x30 */ public float SpaceshipLookAtRadius;
    }
}
