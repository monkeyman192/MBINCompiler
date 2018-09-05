namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x335F8)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new string[0x7]{ "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x1D, EnumValue = new string[0x1D] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch", "TreasureRuins", "GameStartSpawn"
            })]
        /* 0x32C00 */ public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
