using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xE94EBE3C24823966, NameHash = 0x13D76408C6BF207D)]
    public class GcRealitySubstanceCategory : NMSTemplate
    {
        // size: 0x9
		public enum SubstanceCategoryEnum { Fuel, Metal, Catalyst, Stellar, Flora, Earth, Exotic, Special, BuildingPart }
		public SubstanceCategoryEnum SubstanceCategory;
    }
}