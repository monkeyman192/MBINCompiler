namespace libMBIN.Models.Structs
{
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
		public enum GalaxyWaypointTypeEnum { User, Gameplay_AtlasStation, Gameplay_DistressBeacon, Gameplay_BlackHole, Gameplay_Mission }
		public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}
