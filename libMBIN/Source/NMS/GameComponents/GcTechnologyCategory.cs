using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA5833BBFD06A4101, NameHash = 0xA5FDDD239156B452)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0xE
		public enum TechnologyCategoryEnum {
            Ship, Weapon, Suit, Personal, All, None, Freighter, Maintenance, Exocraft, Submarine,
            Mech, AllVehicles, AlienShip, AllShips
        }
		public TechnologyCategoryEnum TechnologyCategory;
    }
}
