namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x50)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Animation;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DroneAnimation;
        /* 0x20 */ public float Offset;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        [NMS(Size = 0x1D, EnumValue = new string[0x1D] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base", "MissionTower",
                "CrashedFreighter", "GraveInCave", "StoryGlitch", "TreasureRuins", "GameStartSpawn"
            })]
        /* 0x26 */ public bool[] AvailableBuildings;
        [NMS(Size = 0x7, EnumValue = new string[0x7] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x43 */ public bool[] AvailableRaces;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x4A */ public byte[] EndPadding;
    }
}
