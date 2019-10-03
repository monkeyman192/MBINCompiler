using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC6B511D5C5B06A8E, NameHash = 0x52B0589631E97AC5)]
    public class GcCustomisationComponentData : NMSTemplate
    {
        // size = 0xE
		public enum CustomisationDataTypeEnum { Player, Vehicle, Weapon, Ship_01, Ship_02, Ship_03, Ship_04, Ship_05, Ship_06,
                                                Vehicle_Bike, Vehicle_Truck, Vehicle_WheeledBike, Vehicle_Hovercraft, Vehicle_Submarine }
		public CustomisationDataTypeEnum CustomisationDataType;
    }
}
