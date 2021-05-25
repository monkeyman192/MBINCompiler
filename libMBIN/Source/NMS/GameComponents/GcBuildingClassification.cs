using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x4B1C59F03FDA4DDF, NameHash = 0x51606DB6648C8792)]
    public class GcBuildingClassification : NMSTemplate
    {
        // size: 0x24
		public enum BuildingClassEnum {
            None, TerrainResource, Shelter, Abandoned, Terminal, Shop, Outpost, Waypoint, Beacon, RadioTower,
            Observatory, Depot, Factory, Harvester, Plaque, Monolith, Portal, Ruin, Debris, DamagedMachine,
            DistressSignal, LandingPad, Base, MissionTower, CrashedFreighter, GraveInCave, StoryGlitch, TreasureRuins, GameStartSpawn, WaterCrashedFreighter,
            WaterTreasureRuins, WaterAbandoned, WaterDistressSignal, NPCDistressSignal, NPCDebris, LargeBuilding
        }
		public BuildingClassEnum BuildingClass;
    }
}