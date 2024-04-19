using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF87D71ED70DA7A24, NameHash = 0x98F83A1A50531877)]
    public class GcPlanetWaterData : NMSTemplate
    {
        /* 0x000 */ public GcPlanetHeavyAirData HeavyAir;
        /* 0x120 */ public int ColourIndex;
        /* 0x124 */ public float Foam1Scale;
        /* 0x128 */ public float Foam1Speed;
        /* 0x12C */ public float Foam2Scale;
        /* 0x130 */ public float Foam2Speed;
        /* 0x134 */ public float FoamFadeHeight;
        /* 0x138 */ public float FresnelMax;
        /* 0x13C */ public float FresnelMin;
        /* 0x140 */ public float FresnelPower;
        /* 0x144 */ public float NormalMap1Scale;
        /* 0x148 */ public float NormalMap1Speed;
        /* 0x14C */ public float NormalMap2Scale;
        /* 0x150 */ public float NormalMap2Speed;
        /* 0x154 */ public float WaterColourStrength;
        /* 0x158 */ public float WaterMultiplyMax;
        /* 0x15C */ public float WaterMultiplyStrength;
        /* 0x160 */ public float WaterRoughness;
        /* 0x164 */ public float WaterStrength;
        /* 0x168 */ public float Wave1Height;
        /* 0x16C */ public float Wave1Scale;
        /* 0x170 */ public float Wave1Speed;
        /* 0x174 */ public float Wave2Height;
        /* 0x178 */ public float Wave2Scale;
        /* 0x17C */ public float Wave2Speed;
    }
}
