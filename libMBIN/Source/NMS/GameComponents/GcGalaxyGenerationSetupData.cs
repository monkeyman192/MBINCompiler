using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD69498AB6E7B213, NameHash = 0x74E6E445263E30C1)]
    public class GcGalaxyGenerationSetupData : NMSTemplate
    {
        [NMS(Index = 31, Size = 0xA)]
        /* 0x000 */ public Colour[] InnerSectorColours;
        [NMS(Index = 20)]
        /* 0x0A0 */ public Vector4f InnerFieldScales;
        [NMS(Index = 4)]
        /* 0x0B0 */ public Vector3f SpiralPull;
        [NMS(Index = 13, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0C0 */ public Vector2f[] StarSize;
        [NMS(Index = 12)]
        /* 0x0E0 */ public Vector2f BaseSize;
        [NMS(Index = 7)]
        /* 0x0E8 */ public Vector2f ConnectionAttractorMax;
        [NMS(Index = 8)]
        /* 0x0F0 */ public Vector2f ConnectionAttractorMin;
        [NMS(Index = 9)]
        /* 0x0F8 */ public Vector2f ConnectionDistortion;
        [NMS(Index = 2)]
        /* 0x100 */ public Vector2f SpiralFlex;
        [NMS(Index = 1)]
        /* 0x108 */ public Vector2f SpiralInclusion;
        [NMS(Index = 5)]
        /* 0x110 */ public Vector2f SpiralSizeScale;
        [NMS(Index = 28)]
        /* 0x118 */ public Vector2f StarHighlightAlpha;
        [NMS(Index = 29)]
        /* 0x120 */ public Vector2f StarHighlightSize;
        [NMS(Index = 17)]
        /* 0x128 */ public float BaseGenerationThreshold;
        [NMS(Index = 16)]
        /* 0x12C */ public float BaseTurbulenceGain;
        [NMS(Index = 15)]
        /* 0x130 */ public float BaseTurbulenceLac;
        [NMS(Index = 14)]
        /* 0x134 */ public float BaseTurbulenceScale;
        [NMS(Index = 30)]
        /* 0x138 */ public float ColourBaseBlendOnSize;
        [NMS(Index = 11)]
        /* 0x13C */ public float ConnectionDistanceLimit;
        [NMS(Index = 10)]
        /* 0x140 */ public float ConnectionDistortionTMult;
        [NMS(Index = 18)]
        /* 0x144 */ public float FieldGenerationThreshold;
        [NMS(Index = 24)]
        /* 0x148 */ public float FieldAlphaBase;
        [NMS(Index = 25)]
        /* 0x14C */ public float FieldAlphaField1Inf;
        [NMS(Index = 26)]
        /* 0x150 */ public float FieldAlphaField2SqInf;
        [NMS(Index = 6)]
        /* 0x154 */ public float RareSunChance;
        [NMS(Index = 23)]
        /* 0x158 */ public float SizeField4Inf;
        [NMS(Index = 22)]
        /* 0x15C */ public float SizeNoisePower;
        [NMS(Index = 21)]
        /* 0x160 */ public float SizeNoiseScale;
        [NMS(Index = 0)]
        /* 0x164 */ public float SpiralFormChance;
        [NMS(Index = 3)]
        /* 0x168 */ public float SpiralTwistMult;
        [NMS(Index = 19)]
        /* 0x16C */ public float StarGenerationThreshold;
        [NMS(Index = 27)]
        /* 0x170 */ public float StarHighlightChance;
    }
}
