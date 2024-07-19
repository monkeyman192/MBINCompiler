using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4157B48B2440CAA5, NameHash = 0x35FB80FE)]
    public class GcWaterGlobals : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x000 */ public GcPlanetWaterData WaterDataDay;
        [NMS(Index = 14)]
        /* 0x1B0 */ public GcPlanetWaterColourData WaterColourNight;
        [NMS(Index = 12)]
        /* 0x210 */ public Colour WaterHeavyAirColour;
        [NMS(Index = 5)]
        /* 0x220 */ public float Epsilon;
        [NMS(Index = 8)]
        /* 0x224 */ public float FresnelAlpha;
        [NMS(Index = 11)]
        /* 0x228 */ public float FresnelBelowAlpha;
        [NMS(Index = 10)]
        /* 0x22C */ public float FresnelBelowMul;
        [NMS(Index = 9)]
        /* 0x230 */ public float FresnelBelowPow;
        [NMS(Index = 7)]
        /* 0x234 */ public float FresnelMul;
        [NMS(Index = 6)]
        /* 0x238 */ public float FresnelPow;
        [NMS(Index = 3)]
        /* 0x23C */ public float WaveChoppiness;
        [NMS(Index = 4)]
        /* 0x240 */ public float WaveCutoff;
        [NMS(Index = 2)]
        /* 0x244 */ public float WaveFrequency;
        [NMS(Index = 1)]
        /* 0x248 */ public float WaveHeight;
        [NMS(Index = 0)]
        /* 0x24C */ public bool UseNewWater;
    }
}
