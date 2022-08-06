using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xF5BC9F27DFFC1970, NameHash = 0x6A6072ECC3DD12D0)]
    public class GcWaterGlobals : NMSTemplate
    {
        /* 0x000 */ public bool RenderReflections;
        /* 0x001 */ public bool UseNewWater;
        /* 0x004 */ public float WaveHeight;
        /* 0x008 */ public float WaveFrequency;
        /* 0x00C */ public float WaveChoppiness;
        /* 0x010 */ public float WaveCutoff;
        /* 0x014 */ public float Epsilon;
        /* 0x018 */ public float FresnelPow;
        /* 0x01C */ public float FresnelMul;
        /* 0x020 */ public float FresnelAlpha;
        /* 0x024 */ public float FresnelBelowPow;
        /* 0x028 */ public float FresnelBelowMul;
        /* 0x02C */ public float FresnelBelowAlpha;
        /* 0x030 */ public Colour WaterHeavyAirColour;
        /* 0x040 */ public GcPlanetWaterData WaterDataDay;
        /* 0x1C0 */ public GcPlanetWaterColourData WaterColourNight;
    }
}
