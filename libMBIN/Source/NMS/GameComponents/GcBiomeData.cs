using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5D0, GUID = 0xE1057DFD12CBAF47, NameHash = 0x2FD5560612237D4D)]
    public class GcBiomeData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 TextureFile;
        /* 0x080 */ public NMSString0x80 TileTypesFile;
        /* 0x100 */ public NMSString0x80 ColourPaletteFile;
        /* 0x180 */ public NMSString0x80 LegacyColourPaletteFile;
        /* 0x200 */ public GcMiningSubstanceData MiningSubstance1;
        /* 0x20C */ public GcMiningSubstanceData MiningSubstance2;
        /* 0x218 */ public GcMiningSubstanceData MiningSubstance3;
        /* 0x224 */ public float FuelMultiplier;
        /* 0x230 */ public GcPlanetWaterData Water;
        /* 0x3B0 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x3C0 */ public GcWeatherWeightings[] WeatherOptions;
        /* 0x4C0 */ public Vector2f WeatherChangeTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4C8 */ public byte[] Padding4B8;
        /* 0x4D0 */ public GcBiomeCloudSettings CloudSettings;
        /* 0x520 */ public GcTerrainControls Terrain;
        /* 0x598 */ public List<GcScreenFilterOption> FilterOptions;
        /* 0x5A8 */ public NMSString0x20 FloraLifeLocID;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x5C8 */ public byte[] EndPadding;
    }
}
