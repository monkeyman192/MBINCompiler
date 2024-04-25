namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA87D6CA497B95EAD, NameHash = 0x894C8A7A0498F6C5)]
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        // size: 0x23
        public enum ScanBuildingIconTypeEnum : uint {
            None,
            Generic,
            Shelter,
            Relic,
            Factory,
            Unknown,
            Distress,
            Beacon,
            Waypoint,
            SpaceStation,
            TechResource,
            FuelResource,
            MineralResource,
            SpaceAnomaly,
            SpaceAtlas,
            ExternalBase,
            PlanetBaseTerminal,
            Nexus,
            AbandonedFreighter,
            Telescope,
            Outpost,
            UpgradePod,
            Cog,
            Ruins,
            Portal,
            Library,
            Abandoned,
            SmallBuilding,
            StoryGlitch,
            GraveInCave,
            HoloHub,
            Settlement,
            DroneHive,
            SentinelDistress,
            AbandonedRobotCamp,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanBuildingIconTypeEnum ScanBuildingIconType;
    }
}
