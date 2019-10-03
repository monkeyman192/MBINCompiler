using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xDC, GUID = 0x541CE72CF07274D2, NameHash = 0x32F1C073DAE21750)]
    public class GcFogProperties : NMSTemplate
    {
        /* 0x00 */ public float FogStrength;
        /* 0x04 */ public float FogMax;
        /* 0x08 */ public float FogColourStrength;
        /* 0x0C */ public float FogColourMax;
        /* 0x10 */ public float HeightFogStrength;
        /* 0x14 */ public float HeightFogFadeOutStrength;
        /* 0x18 */ public float HeightFogOffset;
        /* 0x1C */ public float HeightFogMax;
        /* 0x20 */ public float FogHeight;
        /* 0x24 */ public GcHeavyAirSetting HeavyAir;
        /* 0xC4 */ public float CloudRatio;
        /* 0xC8 */ public float FullscreenEffect;
        /* 0xCC */ public float DepthOfField;
        /* 0xD0 */ public float DepthOfFieldDistance;
        /* 0xD4 */ public float DepthOfFieldFade;
        /* 0xD8 */ public bool IsRaining;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding;
    }
}
