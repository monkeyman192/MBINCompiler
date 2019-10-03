using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8EA57E3BE2F39EE6, NameHash = 0x822DDBC250BAB267)]
    public class GcDiscoveryTypes : NMSTemplate
    {
        // 0x10 entries
		public enum DiscoveryTypeEnum { Unknown, SolarSystem, Planet, Animal, Flora, Mineral, Sector, Building, Interactable, Sentinel, Starship, Artifact, Mystery, Treasure, Control, HarvestPlant }
		public DiscoveryTypeEnum DiscoveryType;
    }
}
