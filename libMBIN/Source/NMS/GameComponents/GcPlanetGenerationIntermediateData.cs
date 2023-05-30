using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        public GcSeed Seed;
        public int TerrainSettingIndex;
        public GcGalaxyStarTypes GalaxyStarType;
        public GcPlanetClass PlanetClass;
        public GcPlanetSize PlanetSize;
        public GcCreatureRoleDataTable CreatureRoleData;
        public GcTerrainControls Terrain;
        public GcBiomeType Biome;

        public NMSString0x80 TerrainFile;
        public NMSString0x80 CreatureLandFile;
        public NMSString0x80 CreatureCaveFile;
        public NMSString0x80 CreatureWaterFile;
        public NMSString0x80 CreatureAirFile;
        public NMSString0x80 CreatureRobotFile;
        public List<GcExternalObjectListOptions> ExternalObjectLists;
        public List<int> ExternalObjectListIndices;
    }
}
