using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4F0, GUID = 0x26BD4F194341EF64, NameHash = 0x2FD5560612237D4D)]
    public class GcBiomeData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string TextureFile;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string TileTypesFile;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string ColourPaletteFile;
        [NMS(Size = 0x80)]
        /* 0x180 */ public string LegacyColourPaletteFile;
        /* 0x200 */ public GcMiningSubstanceData MiningSubstance1;
        /* 0x20C */ public GcMiningSubstanceData MiningSubstance2;
        /* 0x218 */ public GcMiningSubstanceData MiningSubstance3;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x224 */ public byte[] Padding224;
        /* 0x230 */ public GcPlanetWaterData Water;

        /* 0x3B0 */ public List<GcExternalObjectListOptions> ExternalObjectLists;

        [NMS(Size = 0x4)]       // probably an enum of the life level
        /* 0x3C0 */ public GcWeatherWeightings[] WeatherOptions;

        /* 0x460 */ public Vector2f WeatherChangeTime;
        /* 0x468 */ public GcTerrainControls Terrain;
        /* 0x4E0 */ public List<GcScreenFilters> FilterOptions;
    }
}
