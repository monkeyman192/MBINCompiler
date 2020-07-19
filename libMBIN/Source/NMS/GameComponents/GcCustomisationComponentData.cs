﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xE1DD27569DF2A7C9, NameHash = 0x52B0589631E97AC5)]
    public class GcCustomisationComponentData : NMSTemplate
    {
        // size = 0x10
		public enum CustomisationDataTypeEnum { Player, Vehicle, Weapon, Ship_01, Ship_02, Ship_03, Ship_04, Ship_05, Ship_06,
                                                Vehicle_Bike, Vehicle_Truck, Vehicle_WheeledBike, Vehicle_Hovercraft, Vehicle_Submarine,
                                                Vehicle_Mech, Freighter}
		public CustomisationDataTypeEnum CustomisationDataType;
    }
}
