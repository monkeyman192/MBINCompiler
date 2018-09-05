using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x340)]
    public class GcBiomeData : NMSTemplate
    {
        /* 0x000 */ public GcMiningSubstanceData MiningSubstance1;
        /* 0x00C */ public GcMiningSubstanceData MiningSubstance2;
        /* 0x018 */ public GcMiningSubstanceData MiningSubstance3;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x024 */ public byte[] Padding24;
        /* 0x030 */ public GcPlanetWaterData Water;

        /* 0x200 */ public List<GcExternalObjectListOptions> ExternalObjectLists;

        [NMS(Size = 0x4)]       // probably an enum of the life level
        /* 0x210 */ public GcWeatherWeightings[] WeatherOptions;

        /* 0x2B0 */ public Vector2f WeatherChangeTime;
        /* 0x2B8 */ public GcTerrainControls Terrain;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x32C */ public byte[] Padding32C;
        /* 0x330 */ public List<GcScreenFilters> FilterOptions;
    }
}
