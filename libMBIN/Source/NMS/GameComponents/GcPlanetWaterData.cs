using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE35B5C5F8B515B0, NameHash = 0x98F83A1A50531877)]
    public class GcPlanetWaterData : NMSTemplate
    {
        /* 0x00 */ public int ColourIndex;      // this *should* correspond to the index of the list entry in the \METADATA\SIMULATION\SOLARSYSTEM\COLOURS\WATERCOLOURS.MBIN file...
        /* 0x04 */ public float WaterStrength;
        /* 0x08 */ public float WaterColourStrength;
        /* 0x0C */ public float WaterMultiplyStrength;
        /* 0x10 */ public float WaterMultiplyMax;
        /* 0x14 */ public float WaterRoughness;
        /* 0x18 */ public float FresnelPower;
        /* 0x1C */ public float FresnelMin;
        /* 0x20 */ public float FresnelMax;
        /* 0x24 */ public float Wave1Scale;
        /* 0x28 */ public float Wave1Height;
        /* 0x2C */ public float Wave1Speed;
        /* 0x30 */ public float Wave2Scale;
        /* 0x34 */ public float Wave2Height;
        /* 0x38 */ public float Wave2Speed;
        /* 0x3C */ public float NormalMap1Scale;
        /* 0x40 */ public float NormalMap1Speed;
        /* 0x44 */ public float NormalMap2Scale;
        /* 0x48 */ public float NormalMap2Speed;
        /* 0x4C */ public float FoamFadeHeight;
        /* 0x50 */ public float Foam1Scale;
        /* 0x54 */ public float Foam1Speed;
        /* 0x58 */ public float Foam2Scale;
        /* 0x5C */ public float Foam2Speed;
        /* 0x60 */ public GcPlanetHeavyAirData HeavyAir;
    }
}
