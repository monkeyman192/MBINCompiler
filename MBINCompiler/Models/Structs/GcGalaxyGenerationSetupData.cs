namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyGenerationSetupData : NMSTemplate
    {
        public float SpiralFormChance;
        public Vector2f SpiralInclusion;
        public Vector2f SpiralFlex;
        public float SpiralTwistMult;

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding18;

        public Vector4f SpiralPull;
        public Vector2f SpiralSizeScale;

        public float RareSunChance;

        public Vector2f ConnectionAttractorMax;
        public Vector2f ConnectionAttractorMin;
        public Vector2f ConnectionDistortion;
        public float ConnectionDistortionTMult;
        public float ConnectionDistanceLimit;

        public Vector2f BaseSize;
        public Vector2f StarSize;

        public float BaseTurbulenceScale;
        public float BaseTurbulenceLac;
        public float BaseTurbulenceGain;

        public float BaseGenerationThreshold;
        public float FieldGenerationThreshold;
        public float StarGenerationThreshold;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding84;

        public Vector4f InnerFieldScales;

        public float SizeNoiseScale;
        public float SizeNoisePower;

        public float SizeField4Inf;

        public float FieldAlphaBase;
        public float FieldAlphaField1Inf;
        public float FieldAlphaField2SqInf;

        public float StarHighlightChance;

        public Vector2f StarHighlightAlpha;
        public Vector2f StarHighlightSize;

        public float ColourBaseBlendOnSize;

        [NMS(Size = 10)]
        public Colour[] InnerSectorColours;
    }
}
