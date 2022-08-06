using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7E48ABB6B97E571, NameHash = 0x7333B5EC725370EF)]
    public class GcPlanetSkyProperties : NMSTemplate
    {
        /* 0x000 */ public GcSkyProperties PlanetSky;
        /* 0x030 */ public GcFogProperties PlanetFog;
        /* 0x110 */ public GcFogProperties PlanetExtremeFog;
        /* 0x1F0 */ public GcFogProperties PlanetStormFog;
        /* 0x2D0 */ public GcFogProperties PlanetFlightFog;
    }
}
