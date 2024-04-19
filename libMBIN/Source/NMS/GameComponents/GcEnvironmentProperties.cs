using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5878DB43951227CC, NameHash = 0xB125AED843BB9164)]
    public class GcEnvironmentProperties : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x00 */ public float[] SkyHeight;
        /* 0x10 */ public float AsteroidFadeHeightMax;
        /* 0x14 */ public float AsteroidFadeHeightMin;
        /* 0x18 */ public float AtmosphereEndHeight;
        /* 0x1C */ public float AtmosphereStartHeight;
        /* 0x20 */ public float CloudHeightMax;
        /* 0x24 */ public float CloudHeightMin;
        /* 0x28 */ public float FlightFogBlend;
        /* 0x2C */ public float FlightFogHeight;
        /* 0x30 */ public float HeavyAirHeightMax;
        /* 0x34 */ public float HeavyAirHeightMin;
        /* 0x38 */ public float HorizonBlendHeight;
        /* 0x3C */ public float HorizonBlendLength;
        /* 0x40 */ public float PlanetLodSwitch0;
        /* 0x44 */ public float PlanetLodSwitch0Elevation;
        /* 0x48 */ public float PlanetLodSwitch1;
        /* 0x4C */ public float PlanetLodSwitch2;
        /* 0x50 */ public float PlanetLodSwitch3;
        /* 0x54 */ public float PlanetObjectSwitch;
        /* 0x58 */ public float SkyAtmosphereHeight;
        /* 0x5C */ public float SkyColourBlendLength;
        /* 0x60 */ public float SkyColourHeight;
        /* 0x64 */ public float SkyPositionBlendLength;
        /* 0x68 */ public float SkyPositionHeight;
        /* 0x6C */ public float SolarSystemLUTBlendLength;
        /* 0x70 */ public float SolarSystemLUTHeight;
        /* 0x74 */ public float StratosphereHeight;
    }
}
