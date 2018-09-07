namespace libMBIN.Models.Structs
{
    public class GcDiscoveryTypes : NMSTemplate
    {
		public enum DiscoveryTypeEnum { Unknown, SolarSystem, Planet, Animal, Flora, Mineral, Sector, Building, Interactable, Sentinel, Starship, Artifact, Mystery, Treasure, Control }
		public DiscoveryTypeEnum DiscoveryType;
    }
}
