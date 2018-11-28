using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS( Size = 0x4, GUID = 0x4954B4164DF06290 )]
    public class GcBuildingClassification : NMSTemplate
    {
        public enum BuildingClassEnum {
            None, TerrainResource, Shelter, Abandoned, Terminal, Shop, Outpost, Waypoint,
            Beacon, RadioTower, Observatory, Depot, Factory, Harvester, Plaque, Monolith,
            Portal, Ruin, Debris, DamagedMachine, DistressSignal, LandingPad, Base, MissionTower,
            CrashedFreighter, GraveInCave, StoryGlitch, TreasureRuins, GameStartSpawn,
            WaterCrashedFreighter, WaterTreasureRuins, WaterAbandoned, WaterDistressSignal
        }
        public BuildingClassEnum BuildingClass;
    }
}
