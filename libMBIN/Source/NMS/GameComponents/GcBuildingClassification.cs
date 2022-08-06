using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x62A172CABE333305, NameHash = 0x51606DB6648C8792)]
    public class GcBuildingClassification : NMSTemplate
    {
        // size: 0x34
		public enum BuildingClassEnum {
            None, TerrainResource, Shelter, Abandoned, Terminal, Shop, Outpost, Waypoint, Beacon, RadioTower,
            Observatory, Depot, Factory, Harvester, Plaque, Monolith, Portal, Ruin, Debris, DamagedMachine,
            DistressSignal, LandingPad, Base, MissionTower, CrashedFreighter, GraveInCave, StoryGlitch, TreasureRuins, GameStartSpawn, WaterCrashedFreighter,
            WaterTreasureRuins, WaterAbandoned, WaterDistressSignal, NPCDistressSignal, NPCDebris, LargeBuilding, Settlement_Hub, Settlement_LandingZone, Settlement_Bar, Settlement_Tower,
            Settlement_Market, Settlement_Small, Settlement_SmallIndustrial, Settlement_Medium, Settlement_Large, Settlement_Monument, Settlement_SheriffsOffice, Settlement_Double, Settlement_Farm, Settlement_Factory,
            Settlement_Clump, DroneHive
        }
		public BuildingClassEnum BuildingClass;
    }
}