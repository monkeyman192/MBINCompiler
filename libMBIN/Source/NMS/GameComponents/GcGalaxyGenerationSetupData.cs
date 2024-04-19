using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD69498AB6E7B213, NameHash = 0x74E6E445263E30C1)]
    public class GcGalaxyGenerationSetupData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x000 */ public Colour[] InnerSectorColours;
        /* 0x0A0 */ public Vector4f InnerFieldScales;
        /* 0x0B0 */ public Vector3f SpiralPull;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0C0 */ public Vector2f[] StarSize;
        /* 0x0E0 */ public Vector2f BaseSize;
        /* 0x0E8 */ public Vector2f ConnectionAttractorMax;
        /* 0x0F0 */ public Vector2f ConnectionAttractorMin;
        /* 0x0F8 */ public Vector2f ConnectionDistortion;
        /* 0x100 */ public Vector2f SpiralFlex;
        /* 0x108 */ public Vector2f SpiralInclusion;
        /* 0x110 */ public Vector2f SpiralSizeScale;
        /* 0x118 */ public Vector2f StarHighlightAlpha;
        /* 0x120 */ public Vector2f StarHighlightSize;
        /* 0x128 */ public float BaseGenerationThreshold;
        /* 0x12C */ public float BaseTurbulenceGain;
        /* 0x130 */ public float BaseTurbulenceLac;
        /* 0x134 */ public float BaseTurbulenceScale;
        /* 0x138 */ public float ColourBaseBlendOnSize;
        /* 0x13C */ public float ConnectionDistanceLimit;
        /* 0x140 */ public float ConnectionDistortionTMult;
        /* 0x144 */ public float FieldGenerationThreshold;
        /* 0x148 */ public float FieldAlphaBase;
        /* 0x14C */ public float FieldAlphaField1Inf;
        /* 0x150 */ public float FieldAlphaField2SqInf;
        /* 0x154 */ public float RareSunChance;
        /* 0x158 */ public float SizeField4Inf;
        /* 0x15C */ public float SizeNoisePower;
        /* 0x160 */ public float SizeNoiseScale;
        /* 0x164 */ public float SpiralFormChance;
        /* 0x168 */ public float SpiralTwistMult;
        /* 0x16C */ public float StarGenerationThreshold;
        /* 0x170 */ public float StarHighlightChance;
    }
}
