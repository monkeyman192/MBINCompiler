namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42BCABB3F2D44B9B, NameHash = 0x71B7896BF38DAAE4)]
    public class GcAlienPodComponentData : NMSTemplate
    {
        /* 0x00 */ public float AgroMovement;
        /* 0x04 */ public float AgroMovementRange;
        /* 0x08 */ public float AgroRate;
        /* 0x0C */ public float AgroSpookTime;
        /* 0x10 */ public float AgroSpookTimeMax;
        /* 0x14 */ public float AgroSpookTimeMin;
        /* 0x18 */ public float AgroSpookValue;
        /* 0x1C */ public float AgroThreshold;
        /* 0x20 */ public float AgroThresholdOffscreen;
        /* 0x24 */ public float AgroTorch;
        /* 0x28 */ public float AgroTorchFOV;
        /* 0x2C */ public float AgroTorchRange;
        /* 0x30 */ public float GlowIntensityMax;
        /* 0x34 */ public float GlowIntensityMin;
        /* 0x38 */ public float GunfireAgro;
        /* 0x3C */ public float GunfireAgroRange;
        /* 0x40 */ public float InstaAgroDistance;
    }
}
