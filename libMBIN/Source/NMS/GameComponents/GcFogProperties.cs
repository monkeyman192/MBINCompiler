using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
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
        public GcHeavyAirSetting HeavyAirSettings;
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
