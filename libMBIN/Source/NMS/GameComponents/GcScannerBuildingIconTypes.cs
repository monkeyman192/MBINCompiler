using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC90BD7FD825AF604, NameHash = 0x894C8A7A0498F6C5)]
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        // 0x12 entries
		public enum ScanBuildingIconTypesEnum { None, Generic, Shelter, Relic, Factory, Unknown, Distress, Beacon, Waypoint, SpaceStation, TechResource, FuelResource, MineralResource, SpaceAnomaly, SpaceAtlas, ExternalBase, PlanetBaseTerminal, Nexus }
		public ScanBuildingIconTypesEnum ScanBuildingIconTypes;
    }
}
