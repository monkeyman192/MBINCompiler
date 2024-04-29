using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1B1E5E50CB40919, NameHash = 0x4548C9A8732E084E)]
    public class GcCamouflageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkMaterialResource CamouflageMaterial;
        [NMS(Index = 1)]
        /* 0x84 */ public float DissolveTime;
        [NMS(Index = 2)]
        /* 0x88 */ public float DissolveTimeVR;
        [NMS(Index = 4)]
        /* 0x8C */ public float FadeInTime;
        [NMS(Index = 3)]
        /* 0x90 */ public float FadeOutTime;
        [NMS(Index = 6)]
        /* 0x94 */ public float LowQualityBrightnessMultiplier;
        [NMS(Index = 5)]
        /* 0x98 */ public float LowQualityFresnelModifier;
    }
}
