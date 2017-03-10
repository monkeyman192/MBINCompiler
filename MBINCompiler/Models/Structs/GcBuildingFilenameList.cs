namespace MBINCompiler.Models.Structs
{
    public class GcBuildingFilenameList : NMSTemplate // 0x2C00 bytes
    {
        [NMS(Size = 0x17, EnumValue = new string[0x17] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base"
            })]
        public GcBuildingFilename[] BuildingFiles;
    }
}
