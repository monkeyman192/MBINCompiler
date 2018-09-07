namespace libMBIN.Models.Structs
{
    public class GcPhysicsCollisionGroups : NMSTemplate
    {
		public enum CollisionGroupEnum { Normal, Water, Terrain, Substance, Asteroid, TerrainInstance, TerrainActivated, Player, Creature, Spaceship, Debris, Shield, Waypoint, NetworkPlayer }
		public CollisionGroupEnum CollisionGroup;
    }
}
