namespace libMBIN.Models.Structs
{
    public class GcBuildingClassification : NMSTemplate
    {
		public enum BuildingClassEnum { None, TerrainResource, Shelter, Abandoned, Terminal, Shop, Outpost, Waypoint, Beacon, RadioTower, Observatory, Depot, Factory, Harvester,
                                        Plaque, Monolith, Portal, Ruin, Debris, DamagedMachine, DistressSignal, LandingPad, Base, MissionTower, CrashedFreighter, GraveInCave,
                                        StoryGlitch, TreasureRuins, GameStartSpawn }
		public BuildingClassEnum BuildingClass;
    }
}
