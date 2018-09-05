namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1D0)]
    public class GcPlanetWaterData : NMSTemplate
    {
        /* 0x00 */ public Colour WaterFogColourNear;
        /* 0x10 */ public Colour WaterFogColourFar;
        /* 0x20 */ public Colour WaterColourBase;
        /* 0x30 */ public Colour WaterColourAdd;
        /* 0x40 */ public float WaterStrength;
        /* 0x44 */ public float WaterColourStrength;
        /* 0x48 */ public float WaterMultiplyStrength;
        /* 0x4C */ public float WaterMultiplyMax;
        /* 0x50 */ public float WaterRoughness;
        /* 0x54 */ public float FresnelPower;
        /* 0x58 */ public float FresnelMin;
        /* 0x5C */ public float FresnelMax;
        /* 0x60 */ public float Wave1Scale;
        /* 0x64 */ public float Wave1Height;
        /* 0x68 */ public float Wave1Speed;
        /* 0x6C */ public float Wave2Scale;
        /* 0x70 */ public float Wave2Height;
        /* 0x74 */ public float Wave2Speed;
        /* 0x78 */ public float NormalMap1Scale;
        /* 0x7C */ public float NormalMap1Speed;
        /* 0x80 */ public float NormalMap2Scale;
        /* 0x84 */ public float NormalMap2Speed;
        /* 0x88 */ public float FoamFadeHeight;
        /* 0x8C */ public float Foam1Scale;
        /* 0x90 */ public float Foam1Speed;
        /* 0x94 */ public float Foam2Scale;
        /* 0x98 */ public float Foam2Speed;
        /* 0xA0 */ public Colour FoamColour;
        /* 0xB0 */ public GcPlanetHeavyAirData HeavyAir;
    }
}
