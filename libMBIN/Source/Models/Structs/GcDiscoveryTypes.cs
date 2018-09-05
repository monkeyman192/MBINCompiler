namespace libMBIN.Models.Structs
{
    public class GcDiscoveryTypes : NMSTemplate
    {
        public int DiscoveryType;
        public string[] DiscoveryTypeValues()
        {
            return new[] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector", "Building", "Interactable", "Sentinel",
                           "Starship", "Artifact", "Mystery", "Treasure", "Control"};
        }
    }
}
