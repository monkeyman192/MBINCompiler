namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        public int GalaxyWaypointType;
        public string[] GalaxyWaypointTypeValues()
        {
            return new[] { "User", "Gameplay_AtlasStation", "Gameplay_DistressBeacon", "Gameplay_Mission"};
        }
    }
}
