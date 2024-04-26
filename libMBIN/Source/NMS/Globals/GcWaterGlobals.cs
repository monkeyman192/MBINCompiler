using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA518900715F7C824, NameHash = 0x6A6072ECC3DD12D0)]
    public class GcWaterGlobals : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x000 */ public GcPlanetWaterData WaterDataDay;
        [NMS(Index = 14)]
        /* 0x180 */ public GcPlanetWaterColourData WaterColourNight;
        [NMS(Index = 12)]
        /* 0x1D0 */ public Colour WaterHeavyAirColour;
        [NMS(Index = 5)]
        /* 0x1E0 */ public float Epsilon;
        [NMS(Index = 8)]
        /* 0x1E4 */ public float FresnelAlpha;
        [NMS(Index = 11)]
        /* 0x1E8 */ public float FresnelBelowAlpha;
        [NMS(Index = 10)]
        /* 0x1EC */ public float FresnelBelowMul;
        [NMS(Index = 9)]
        /* 0x1F0 */ public float FresnelBelowPow;
        [NMS(Index = 7)]
        /* 0x1F4 */ public float FresnelMul;
        [NMS(Index = 6)]
        /* 0x1F8 */ public float FresnelPow;
        [NMS(Index = 3)]
        /* 0x1FC */ public float WaveChoppiness;
        [NMS(Index = 4)]
        /* 0x200 */ public float WaveCutoff;
        [NMS(Index = 2)]
        /* 0x204 */ public float WaveFrequency;
        [NMS(Index = 1)]
        /* 0x208 */ public float WaveHeight;
        [NMS(Index = 0)]
        /* 0x20C */ public bool UseNewWater;
    }
}
