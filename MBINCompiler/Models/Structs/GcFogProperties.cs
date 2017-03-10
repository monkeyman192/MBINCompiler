namespace MBINCompiler.Models.Structs
{
    public class GcFogProperties : NMSTemplate
    {
        public float FogStrength;
        public float FogMax;
        public float FogColourStrength;
        public float FogColourMax;
        public float HeightFogStrength;
        public float HeightFogFadeOutStrength;
        public float HeightFogOffset;
        public float HeightFogMax;
        public float FogHeight;
        public GcHeavyAirSetting HeavyAir; // Originally was HeavyAirSettings but from IDA I think it should just be HeavyAir
        public float CloudRatio;
        public float FullscreenEffect;
        public float DepthOfField;
        public float DepthOfFieldDistance;
        public float DepthOfFieldFade;
        public bool IsRaining;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding;
    }
}
