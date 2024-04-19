namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4955099D564BF21D, NameHash = 0x566CA1D9F6501832)]
    public class GcCharacterLookAtData : NMSTemplate
    {
        /* 0x00 */ public float CreatureLookAtRadius;
        /* 0x04 */ public float InteractionLookAtRadius;
        /* 0x08 */ public float LookAtMaxPitch;
        /* 0x0C */ public float LookAtMaxYaw;
        /* 0x10 */ public float LookAtRunGlanceMaxTime;
        /* 0x14 */ public float LookAtRunGlanceMinTime;
        /* 0x18 */ public float LookAtRunMaxTime;
        /* 0x1C */ public float LookAtRunMinTime;
        /* 0x20 */ public float LookAtTargetGlanceMaxTime;
        /* 0x24 */ public float LookAtTargetGlanceMinTime;
        /* 0x28 */ public float LookAtTargetWaitMaxTime;
        /* 0x2C */ public float LookAtTargetWaitMinTime;
        /* 0x30 */ public float SpaceshipLookAtRadius;
    }
}
