using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91A216B37885BAFE, NameHash = 0x2B1C4525)]
    public class GcPlanetSkyProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcFogProperties PlanetExtremeFog;
        [NMS(Index = 4)]
        /* 0x1D0 */ public GcFogProperties PlanetFlightFog;
        [NMS(Index = 1)]
        /* 0x3A0 */ public GcFogProperties PlanetFog;
        [NMS(Index = 3)]
        /* 0x570 */ public GcFogProperties PlanetStormFog;
        [NMS(Index = 0)]
        /* 0x740 */ public GcSkyProperties PlanetSky;
    }
}
