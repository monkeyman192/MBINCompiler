namespace libMBIN.Models.Structs
{
    public class GcBuildingClassification : NMSTemplate
    {
        public int BuildingClass;
        public string[] BuildingClassValues()
        {
            return new[]
            {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch", "TreasureRuins", "GameStartSpawn"
            };
        }
    }
}
