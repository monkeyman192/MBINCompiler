using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF31508D2521D62EB, NameHash = 0xCB4FC853C028D8AE)]
    public class GcSpaceSkyProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour PlanetHorizonColour;
        [NMS(Index = 1)]
        /* 0x10 */ public Colour PlanetSkyColour;
        [NMS(Index = 0)]
        /* 0x20 */ public GcPlanetWeatherColourIndex ColourIndex;
        [NMS(Index = 7)]
        /* 0x28 */ public float AtmosphereThickness;
        [NMS(Index = 6)]
        /* 0x2C */ public float CenterPower;
        [NMS(Index = 27)]
        /* 0x30 */ public float CloudNoiseFrequency;
        [NMS(Index = 9)]
        /* 0x34 */ public float HorizonFadeSpeed;
        [NMS(Index = 8)]
        /* 0x38 */ public float HorizonMultiplier;
        [NMS(Index = 20)]
        /* 0x3C */ public float NebulaBrightness;
        [NMS(Index = 24)]
        /* 0x40 */ public float NebulaCloudStrength;
        [NMS(Index = 25)]
        /* 0x44 */ public float NebulaCloudStrength1;
        [NMS(Index = 31)]
        /* 0x48 */ public float NebulaDistortionStrength;
        [NMS(Index = 29)]
        /* 0x4C */ public float NebulaFBMStrength;
        [NMS(Index = 30)]
        /* 0x50 */ public float NebulaFBMStrength1;
        [NMS(Index = 23)]
        /* 0x54 */ public float NebulaFogAmount;
        [NMS(Index = 16)]
        /* 0x58 */ public float NebulaFrequency;
        [NMS(Index = 26)]
        /* 0x5C */ public float NebulaNoiseFrequency;
        [NMS(Index = 21)]
        /* 0x60 */ public float NebulaSeed;
        [NMS(Index = 17)]
        /* 0x64 */ public float NebulaSparseness;
        [NMS(Index = 22)]
        /* 0x68 */ public float NebulaTendrilStrength;
        [NMS(Index = 28)]
        /* 0x6C */ public float NebulaTurbulenceStrength;
        [NMS(Index = 18)]
        /* 0x70 */ public float NebulaWispyness;
        [NMS(Index = 19)]
        /* 0x74 */ public float NebulaWispyness1;
        [NMS(Index = 10)]
        /* 0x78 */ public float PlanetFogStrength;
        [NMS(Index = 13)]
        /* 0x7C */ public float SpaceFogColour2Strength;
        [NMS(Index = 12)]
        /* 0x80 */ public float SpaceFogColourStrength;
        [NMS(Index = 14)]
        /* 0x84 */ public float SpaceFogMax;
        [NMS(Index = 15)]
        /* 0x88 */ public float SpaceFogPlanetMax;
        [NMS(Index = 11)]
        /* 0x8C */ public float SpaceFogStrength;
        [NMS(Index = 5)]
        /* 0x90 */ public float StarVisibility;
        [NMS(Index = 4)]
        /* 0x94 */ public float SunSize;
        [NMS(Index = 3)]
        /* 0x98 */ public float SunStrength;
    }
}
