using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x293AC97E1FE22B39, NameHash = 0xA5FDDD239156B452)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0xB
		public enum TechnologyCategoryEnum { Ship, Weapon, Suit, Personal, All, None, Freighter, Maintenance, Exocraft, Submarine, AllVehicles }
		public TechnologyCategoryEnum TechnologyCategory;
    }
}
