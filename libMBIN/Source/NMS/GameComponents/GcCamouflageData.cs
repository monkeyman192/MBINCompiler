using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8091C6D88EC210B0, NameHash = 0x3883FEBB)]
    public class GcCamouflageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkMaterialResource CamouflageMaterial;
        [NMS(Index = 1)]
        /* 0x18 */ public float DissolveTime;
        [NMS(Index = 2)]
        /* 0x1C */ public float DissolveTimeVR;
        [NMS(Index = 4)]
        /* 0x20 */ public float FadeInTime;
        [NMS(Index = 3)]
        /* 0x24 */ public float FadeOutTime;
        [NMS(Index = 6)]
        /* 0x28 */ public float LowQualityBrightnessMultiplier;
        [NMS(Index = 5)]
        /* 0x2C */ public float LowQualityFresnelModifier;
    }
}
