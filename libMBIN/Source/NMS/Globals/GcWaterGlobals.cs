using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA518900715F7C824, NameHash = 0x6A6072ECC3DD12D0)]
    public class GcWaterGlobals : NMSTemplate
    {
        /* 0x000 */ public GcPlanetWaterData WaterDataDay;
        /* 0x180 */ public GcPlanetWaterColourData WaterColourNight;
        /* 0x1D0 */ public Colour WaterHeavyAirColour;
        /* 0x1E0 */ public float Epsilon;
        /* 0x1E4 */ public float FresnelAlpha;
        /* 0x1E8 */ public float FresnelBelowAlpha;
        /* 0x1EC */ public float FresnelBelowMul;
        /* 0x1F0 */ public float FresnelBelowPow;
        /* 0x1F4 */ public float FresnelMul;
        /* 0x1F8 */ public float FresnelPow;
        /* 0x1FC */ public float WaveChoppiness;
        /* 0x200 */ public float WaveCutoff;
        /* 0x204 */ public float WaveFrequency;
        /* 0x208 */ public float WaveHeight;
        /* 0x20C */ public bool UseNewWater;
    }
}
