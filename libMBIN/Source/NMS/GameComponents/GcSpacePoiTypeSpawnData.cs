using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF65189F85FB210D3, NameHash = 0xBC1544B3)]
    public class GcSpacePoiTypeSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<int> SpawnCountWeights;
        [NMS(Index = 8)]
        /* 0x10 */ public float MaxDistanceFromPlanetAtmosphere;
        [NMS(Index = 9)]
        /* 0x14 */ public float MaxDistanceFromPlanetAtmosphereChanceOfActivation;
        [NMS(Index = 6)]
        /* 0x18 */ public float MaxDistanceFromSpaceStation;
        [NMS(Index = 7)]
        /* 0x1C */ public float MaxDistanceFromSpaceStationChanceOfActivation;
        [NMS(Index = 4)]
        /* 0x20 */ public float MinDistanceFromSpaceStation;
        [NMS(Index = 5)]
        /* 0x24 */ public float MinDistanceFromSpaceStationChanceOfActivation;
        [NMS(Index = 3)]
        /* 0x28 */ public int NumForcedHiddenExtras;
        [NMS(Index = 1)]
        /* 0x2C */ public bool AllowedInAbandonedSystem;
        [NMS(Index = 2)]
        /* 0x2D */ public bool AllowedInEmptySystem;
    }
}
