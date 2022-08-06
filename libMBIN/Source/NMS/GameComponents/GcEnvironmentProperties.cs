using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x201EF4D59CBBD069, NameHash = 0xB125AED843BB9164)]
    public class GcEnvironmentProperties : NMSTemplate
    {
        /* 0x00 */ public float FlightFogheight;
        /* 0x04 */ public float FlightFogBlend;
        /* 0x08 */ public float CloudHeightMin;
        /* 0x0C */ public float CloudHeightMax;
        /* 0x10 */ public float HeavyAirHeightMin;
        /* 0x14 */ public float HeavyAirHeightMax;
        /* 0x18 */ public float PlanetObjectSwitch;
        /* 0x1C */ public float PlanetLodSwitch0;
        /* 0x20 */ public float PlanetLodSwitch0Elevation;
        /* 0x24 */ public float PlanetLodSwitch1;
        /* 0x28 */ public float PlanetLodSwitch2;
        /* 0x2C */ public float PlanetLodSwitch3;
        /* 0x30 */ public float AsteroidFadeHeightMin;
        /* 0x34 */ public float AsteroidFadeHeightMax;
        [NMS(Size = 0x4)]   // Possible enum: GcPlanetSize
        /* 0x38 */ public float[] SkyHeight;
        /* 0x48 */ public float SkyAtmosphereHeight;
        /* 0x4C */ public float HorizonBlendHeight;
        /* 0x50 */ public float HorizonBlendLength;
        /* 0x54 */ public float SkyColourHeight;
        /* 0x58 */ public float SkyColourBlendLength;
        /* 0x5C */ public float SkyPositionHeight;
        /* 0x60 */ public float SkyPositionBlendLength;
        /* 0x64 */ public float SolarSystemLUTHeight;
        /* 0x68 */ public float SolarSystemLUTBlendLength;
        /* 0x6C */ public float AtmosphereStartHeight;
        /* 0x70 */ public float AtmosphereEndHeight;
        /* 0x74 */ public float StratosphereHeight;
    }
}
