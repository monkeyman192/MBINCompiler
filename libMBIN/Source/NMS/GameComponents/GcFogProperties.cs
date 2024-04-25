using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E76621B34CEBAAF, NameHash = 0x32F1C073DAE21750)]
    public class GcFogProperties : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcHeavyAirSetting HeavyAir;
        [NMS(Index = 10)]
        /* 0xA0 */ public float CloudRatio;
        [NMS(Index = 12)]
        /* 0xA4 */ public float DepthOfField;
        [NMS(Index = 13)]
        /* 0xA8 */ public float DepthOfFieldDistance;
        [NMS(Index = 14)]
        /* 0xAC */ public float DepthOfFieldFade;
        [NMS(Index = 3)]
        /* 0xB0 */ public float FogColourMax;
        [NMS(Index = 2)]
        /* 0xB4 */ public float FogColourStrength;
        [NMS(Index = 8)]
        /* 0xB8 */ public float FogHeight;
        [NMS(Index = 1)]
        /* 0xBC */ public float FogMax;
        [NMS(Index = 0)]
        /* 0xC0 */ public float FogStrength;
        [NMS(Index = 11)]
        /* 0xC4 */ public float FullscreenEffect;
        [NMS(Index = 5)]
        /* 0xC8 */ public float HeightFogFadeOutStrength;
        [NMS(Index = 7)]
        /* 0xCC */ public float HeightFogMax;
        [NMS(Index = 6)]
        /* 0xD0 */ public float HeightFogOffset;
        [NMS(Index = 4)]
        /* 0xD4 */ public float HeightFogStrength;
        [NMS(Index = 16)]
        /* 0xD8 */ public float RainWetness;
        [NMS(Index = 15)]
        /* 0xDC */ public bool IsRaining;
    }
}
