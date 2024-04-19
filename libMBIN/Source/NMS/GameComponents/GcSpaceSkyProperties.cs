using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x157FDABAEA56DDB6, NameHash = 0xCB4FC853C028D8AE)]
    public class GcSpaceSkyProperties : NMSTemplate
    {
        /* 0x00 */ public Colour PlanetHorizonColour;
        /* 0x10 */ public Colour PlanetSkyColour;
        /* 0x20 */ public GcPlanetWeatherColourIndex ColourIndex;
        /* 0x28 */ public float AtmosphereThickness;
        /* 0x2C */ public float CenterPower;
        /* 0x30 */ public float CloudNoiseFrequency;
        /* 0x34 */ public float HorizonFadeSpeed;
        /* 0x38 */ public float HorizonMultiplier;
        /* 0x3C */ public float NebulaBrightness;
        /* 0x40 */ public float NebulaCloudStrength;
        /* 0x44 */ public float NebulaCloudStrength1;
        /* 0x48 */ public float NebulaDistortionStrength;
        /* 0x4C */ public float NebulaFBMStrength;
        /* 0x50 */ public float NebulaFBMStrength1;
        /* 0x54 */ public float NebulaFogAmount;
        /* 0x58 */ public float NebulaFrequency;
        /* 0x5C */ public float NebulaNoiseFrequency;
        /* 0x60 */ public float NebulaSeed;
        /* 0x64 */ public float NebulaSparseness;
        /* 0x68 */ public float NebulaTendrilStrength;
        /* 0x6C */ public float NebulaTurbulenceStrength;
        /* 0x70 */ public float NebulaWispyness;
        /* 0x74 */ public float NebulaWispyness1;
        /* 0x78 */ public float PlanetFogStrength;
        /* 0x7C */ public float SpaceFogColour2Strength;
        /* 0x80 */ public float SpaceFogColourStrength;
        /* 0x84 */ public float SpaceFogMax;
        /* 0x88 */ public float SpaceFogPlanetMax;
        /* 0x8C */ public float SpaceFogStrength;
        /* 0x90 */ public float StarVisibility;
        /* 0x94 */ public float SunSize;
        /* 0x98 */ public float SunStrength;
    }
}
