using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x174A85C80730B363, NameHash = 0xCB4FC853C028D8AE)]
    public class GcSpaceSkyProperties : NMSTemplate
    {
        /* 0x00 */ public GcPlanetWeatherColourIndex ColourIndex;
        /* 0x10 */ public Colour PlanetSkyColour;
        /* 0x20 */ public Colour PlanetHorizonColour;
        /* 0x30 */ public float SunStrength;
        /* 0x34 */ public float SunSize;
        /* 0x38 */ public float StarVisibility;
        /* 0x3C */ public float CenterPower;
        /* 0x40 */ public float AtmosphereThickness;
        /* 0x44 */ public float HorizonMultiplier;
        /* 0x48 */ public float HorizonFadeSpeed;
        /* 0x4C */ public float PlanetFogStrength;
        /* 0x50 */ public float SpaceFogStrength;
        /* 0x54 */ public float SpaceFogColourStrength;
        /* 0x58 */ public float SpaceFogColour2Strength;
        /* 0x5C */ public float SpaceFogMax;
        /* 0x60 */ public float SpaceFogPlanetMax;
        /* 0x64 */ public float NebulaFrequency;
        /* 0x68 */ public float NebulaSparseness;
        /* 0x6C */ public float NebulaWispyness;
        /* 0x70 */ public float NebulaWispyness1;
        /* 0x74 */ public float NebulaBrightness;
        /* 0x78 */ public float NebulaSeed;
        /* 0x7C */ public float NebulaTendrilStrength;
        /* 0x80 */ public float NebulaFogAmount;
        /* 0x84 */ public float NebulaCloudStrength;
        /* 0x88 */ public float NebulaCloudStrength1;
        /* 0x8C */ public float NebulaNoiseFrequency;
        /* 0x90 */ public float CloudNoiseFrequency;
        /* 0x94 */ public float NebulaTurbulenceStrength;
        /* 0x98 */ public float NebulaFBMStrength;
        /* 0x9C */ public float NebulaFBMStrength1;
        /* 0xA0 */ public float NebulaDistortionStrength;
    }
}