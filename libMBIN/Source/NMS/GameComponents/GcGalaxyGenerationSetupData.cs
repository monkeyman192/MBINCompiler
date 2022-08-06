using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x139125167CF73FEB, NameHash = 0x74E6E445263E30C1)]
    public class GcGalaxyGenerationSetupData : NMSTemplate
    {
        /* 0x00 */ public float SpiralFormChance;
        /* 0x04 */ public Vector2f SpiralInclusion;
        /* 0x0C */ public Vector2f SpiralFlex;
        /* 0x14 */ public float SpiralTwistMult;
        /* 0x20 */ public Vector3f SpiralPull;
        /* 0x30 */ public Vector2f SpiralSizeScale;
        /* 0x38 */ public float RareSunChance;
        /* 0x3C */ public Vector2f ConnectionAttractorMax;
        /* 0x44 */ public Vector2f ConnectionAttractorMin;
        /* 0x4C */ public Vector2f ConnectionDistortion;
        /* 0x54 */ public float ConnectionDistortionTMult;
        /* 0x58 */ public float ConnectionDistanceLimit;
        /* 0x5C */ public Vector2f BaseSize;
        [NMS(Size = 0x4)]
        /* 0x64 */ public Vector2f[] StarSize;
        /* 0x84 */ public float BaseTurbulenceScale;
        /* 0x88 */ public float BaseTurbulenceLac;
        /* 0x8C */ public float BaseTurbulenceGain;
        /* 0x90 */ public float BaseGenerationThreshold;
        /* 0x94 */ public float FieldGenerationThreshold;
        /* 0x98 */ public float StarGenerationThreshold;
        /* 0xA0 */ public Vector4f InnerFieldScales;
        /* 0xB0 */ public float SizeNoiseScale;
        /* 0xB4 */ public float SizeNoisePower;
        /* 0xB8 */ public float SizeField4Inf;
        /* 0xBC */ public float FieldAlphaBase;
        /* 0xC0 */ public float FieldAlphaField1Inf;
        /* 0xC4 */ public float FieldAlphaField2SqInf;
        /* 0xC8 */ public float StarHighlightChance;
        /* 0xCC */ public Vector2f StarHighlightAlpha;
        /* 0xD4 */ public Vector2f StarHighlightSize;
        /* 0xDC */ public float ColourBaseBlendOnSize;

        [NMS(Size = 0xA)]
        /* 0xE0 */ public Colour[] InnerSectorColours;
    }
}
