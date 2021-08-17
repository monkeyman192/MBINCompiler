using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x44, GUID = 0x97685109DC2E7CF2, NameHash = 0x71B7896BF38DAAE4)]
    public class GcAlienPodComponentData : NMSTemplate
    {
        /* 0x00 */ public float AgroRate;
        /* 0x04 */ public float AgroMovement;
        /* 0x08 */ public float AgroMovementRange;
        /* 0x0C */ public float AgroTorch;
        /* 0x10 */ public float AgroTorchRange;
        /* 0x14 */ public float AgroTorchFOV;
        /* 0x18 */ public float AgroThreshold;
        /* 0x1C */ public float AgroThresholdOffscreen;
        /* 0x20 */ public float AgroSpookValue;
        /* 0x24 */ public float AgroSpookTime;
        /* 0x28 */ public float AgroSpookTimeMin;
        /* 0x2C */ public float AgroSpookTimeMax;
        /* 0x30 */ public float GlowIntensityMin;
        /* 0x34 */ public float GlowIntensityMax;
        /* 0x38 */ public float InstaAgroDistance;
        /* 0x3C */ public float GunfireAgro;
        /* 0x40 */ public float GunfireAgroRange;
    }
}