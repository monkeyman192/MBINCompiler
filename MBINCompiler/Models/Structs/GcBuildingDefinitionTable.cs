namespace MBINCompiler.Models.Structs
{
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcBuildingDensity[] BuildingProbabilities;
        [NMS(Size = 7)]
        public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x17, EnumValue = new string[0x17] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base"
            })]
        public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
