using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1254EF7AA2B97085, NameHash = 0x52B0589631E97AC5)]
    public class GcCustomisationComponentData : NMSTemplate
    {
        // size: 0x11
		public enum CustomisationDataTypeEnum {
            Player, Vehicle, Weapon, Ship_01, Ship_02, Ship_03, Ship_04, Ship_05, Ship_06, Vehicle_Bike,
            Vehicle_Truck, Vehicle_WheeledBike, Vehicle_Hovercraft, Vehicle_Submarine, Vehicle_Mech, Freighter, Pet
        }
		public CustomisationDataTypeEnum CustomisationDataType;
    }
}
