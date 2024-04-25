using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F8F188BA7D03A18, NameHash = 0x7333B5EC725370EF)]
    public class GcPlanetSkyProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcFogProperties PlanetExtremeFog;
        [NMS(Index = 4)]
        /* 0x0E0 */ public GcFogProperties PlanetFlightFog;
        [NMS(Index = 1)]
        /* 0x1C0 */ public GcFogProperties PlanetFog;
        [NMS(Index = 3)]
        /* 0x2A0 */ public GcFogProperties PlanetStormFog;
        [NMS(Index = 0)]
        /* 0x380 */ public GcSkyProperties PlanetSky;
    }
}
