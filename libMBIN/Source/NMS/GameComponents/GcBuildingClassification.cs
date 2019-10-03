using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x552F89471BF9BDE2, NameHash = 0x51606DB6648C8792)]
    public class GcBuildingClassification : NMSTemplate
    {
        // 0x23 entries
		public enum BuildingClassEnum { None, TerrainResource, Shelter, Abandoned, Terminal, Shop, Outpost, Waypoint, Beacon, RadioTower, Observatory, Depot, Factory,
            Harvester, Plaque, Monolith, Portal, Ruin, Debris, DamagedMachine, DistressSignal, LandingPad, Base, MissionTower, CrashedFreighter, GraveInCave, StoryGlitch,
            TreasureRuins, GameStartSpawn, WaterCrashedFreighter, WaterTreasureRuins, WaterAbandoned, WaterDistressSignal, NPCDistressSignal, NPCDebris }
		public BuildingClassEnum BuildingClass;
    }
}
