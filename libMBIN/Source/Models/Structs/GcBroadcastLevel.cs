namespace libMBIN.Models.Structs
{
    public class GcBroadcastLevel : NMSTemplate
    {
        public int GalaxyMarkerType;
        public string[] GalaxyMarkerTypeValues()
        {
            return new[] { "Scene", "LocalModel", "Local"};
        }
    }
}
