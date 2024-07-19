namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F6B6B9FBCA21D27, NameHash = 0x51254FE1)]
    public class GcAlienPodComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float AgroMovement;
        [NMS(Index = 2)]
        /* 0x04 */ public float AgroMovementRange;
        [NMS(Index = 0)]
        /* 0x08 */ public float AgroRate;
        [NMS(Index = 9)]
        /* 0x0C */ public float AgroSpookTime;
        [NMS(Index = 11)]
        /* 0x10 */ public float AgroSpookTimeMax;
        [NMS(Index = 10)]
        /* 0x14 */ public float AgroSpookTimeMin;
        [NMS(Index = 8)]
        /* 0x18 */ public float AgroSpookValue;
        [NMS(Index = 6)]
        /* 0x1C */ public float AgroThreshold;
        [NMS(Index = 7)]
        /* 0x20 */ public float AgroThresholdOffscreen;
        [NMS(Index = 3)]
        /* 0x24 */ public float AgroTorch;
        [NMS(Index = 5)]
        /* 0x28 */ public float AgroTorchFOV;
        [NMS(Index = 4)]
        /* 0x2C */ public float AgroTorchRange;
        [NMS(Index = 13)]
        /* 0x30 */ public float GlowIntensityMax;
        [NMS(Index = 12)]
        /* 0x34 */ public float GlowIntensityMin;
        [NMS(Index = 15)]
        /* 0x38 */ public float GunfireAgro;
        [NMS(Index = 16)]
        /* 0x3C */ public float GunfireAgroRange;
        [NMS(Index = 14)]
        /* 0x40 */ public float InstaAgroDistance;
    }
}
