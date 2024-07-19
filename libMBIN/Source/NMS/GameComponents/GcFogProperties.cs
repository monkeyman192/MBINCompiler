using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1080B8C7BC848FD, NameHash = 0x4AC069D4)]
    public class GcFogProperties : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public GcHeavyAirSetting HeavyAir;
        [NMS(Index = 10)]
        /* 0x190 */ public float CloudRatio;
        [NMS(Index = 12)]
        /* 0x194 */ public float DepthOfField;
        [NMS(Index = 13)]
        /* 0x198 */ public float DepthOfFieldDistance;
        [NMS(Index = 14)]
        /* 0x19C */ public float DepthOfFieldFade;
        [NMS(Index = 3)]
        /* 0x1A0 */ public float FogColourMax;
        [NMS(Index = 2)]
        /* 0x1A4 */ public float FogColourStrength;
        [NMS(Index = 8)]
        /* 0x1A8 */ public float FogHeight;
        [NMS(Index = 1)]
        /* 0x1AC */ public float FogMax;
        [NMS(Index = 0)]
        /* 0x1B0 */ public float FogStrength;
        [NMS(Index = 11)]
        /* 0x1B4 */ public float FullscreenEffect;
        [NMS(Index = 5)]
        /* 0x1B8 */ public float HeightFogFadeOutStrength;
        [NMS(Index = 7)]
        /* 0x1BC */ public float HeightFogMax;
        [NMS(Index = 6)]
        /* 0x1C0 */ public float HeightFogOffset;
        [NMS(Index = 4)]
        /* 0x1C4 */ public float HeightFogStrength;
        [NMS(Index = 16)]
        /* 0x1C8 */ public float RainWetness;
        [NMS(Index = 15)]
        /* 0x1CC */ public bool IsRaining;
    }
}
