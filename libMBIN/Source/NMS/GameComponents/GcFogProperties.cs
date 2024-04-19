using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E76621B34CEBAAF, NameHash = 0x32F1C073DAE21750)]
    public class GcFogProperties : NMSTemplate
    {
        /* 0x00 */ public GcHeavyAirSetting HeavyAir;
        /* 0xA0 */ public float CloudRatio;
        /* 0xA4 */ public float DepthOfField;
        /* 0xA8 */ public float DepthOfFieldDistance;
        /* 0xAC */ public float DepthOfFieldFade;
        /* 0xB0 */ public float FogColourMax;
        /* 0xB4 */ public float FogColourStrength;
        /* 0xB8 */ public float FogHeight;
        /* 0xBC */ public float FogMax;
        /* 0xC0 */ public float FogStrength;
        /* 0xC4 */ public float FullscreenEffect;
        /* 0xC8 */ public float HeightFogFadeOutStrength;
        /* 0xCC */ public float HeightFogMax;
        /* 0xD0 */ public float HeightFogOffset;
        /* 0xD4 */ public float HeightFogStrength;
        /* 0xD8 */ public float RainWetness;
        /* 0xDC */ public bool IsRaining;
    }
}
