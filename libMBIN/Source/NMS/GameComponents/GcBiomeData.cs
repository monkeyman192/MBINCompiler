using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBiomeData : NMSTemplate
    {
        public GcMiningSubstanceData MiningSubstance1;
        public GcMiningSubstanceData MiningSubstance2;
        public GcMiningSubstanceData MiningSubstance3;
        public GcMiningSubstanceData MiningSubstance4;
        public GcPlanetWaterData Water;

        public NMSString0x80 DiffuseMap;
        public NMSString0x80 NormalMap;

        [NMS(Size = 10)]
        public GcTileTypeOptions[] TileTypes;

        public List<GcExternalObjectListOptions> ExternalObjectLists;

        [NMS(Size = 7, EnumValue = new string[7] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive" } )]
        public bool[] WeatherOptions;

        public GcTerrainControls Terrain;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding408;
    }
}
