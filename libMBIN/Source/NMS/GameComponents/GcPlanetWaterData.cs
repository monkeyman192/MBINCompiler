using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B0162BFE22C2ABC, NameHash = 0xCB70E6C1)]
    public class GcPlanetWaterData : NMSTemplate
    {
        [NMS(Index = 24)]
        /* 0x000 */ public GcPlanetHeavyAirData HeavyAir;
        [NMS(Index = 0)]
        /* 0x150 */ public int ColourIndex;
        [NMS(Index = 20)]
        /* 0x154 */ public float Foam1Scale;
        [NMS(Index = 21)]
        /* 0x158 */ public float Foam1Speed;
        [NMS(Index = 22)]
        /* 0x15C */ public float Foam2Scale;
        [NMS(Index = 23)]
        /* 0x160 */ public float Foam2Speed;
        [NMS(Index = 19)]
        /* 0x164 */ public float FoamFadeHeight;
        [NMS(Index = 8)]
        /* 0x168 */ public float FresnelMax;
        [NMS(Index = 7)]
        /* 0x16C */ public float FresnelMin;
        [NMS(Index = 6)]
        /* 0x170 */ public float FresnelPower;
        [NMS(Index = 15)]
        /* 0x174 */ public float NormalMap1Scale;
        [NMS(Index = 16)]
        /* 0x178 */ public float NormalMap1Speed;
        [NMS(Index = 17)]
        /* 0x17C */ public float NormalMap2Scale;
        [NMS(Index = 18)]
        /* 0x180 */ public float NormalMap2Speed;
        [NMS(Index = 2)]
        /* 0x184 */ public float WaterColourStrength;
        [NMS(Index = 4)]
        /* 0x188 */ public float WaterMultiplyMax;
        [NMS(Index = 3)]
        /* 0x18C */ public float WaterMultiplyStrength;
        [NMS(Index = 5)]
        /* 0x190 */ public float WaterRoughness;
        [NMS(Index = 1)]
        /* 0x194 */ public float WaterStrength;
        [NMS(Index = 10)]
        /* 0x198 */ public float Wave1Height;
        [NMS(Index = 9)]
        /* 0x19C */ public float Wave1Scale;
        [NMS(Index = 11)]
        /* 0x1A0 */ public float Wave1Speed;
        [NMS(Index = 13)]
        /* 0x1A4 */ public float Wave2Height;
        [NMS(Index = 12)]
        /* 0x1A8 */ public float Wave2Scale;
        [NMS(Index = 14)]
        /* 0x1AC */ public float Wave2Speed;
    }
}
