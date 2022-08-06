using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37B50CC696EF7268, NameHash = 0x52B0589631E97AC5)]
    public class GcCustomisationComponentData : NMSTemplate
    {
        // size: 0x14
        public enum CustomisationDataTypeEnum { Player, Vehicle, Weapon, Ship_01, Ship_02, Ship_03, Ship_04, Ship_05, Ship_06,
            Vehicle_Bike, Vehicle_Truck, Vehicle_WheeledBike, Vehicle_Hovercraft,
            Vehicle_Submarine, Vehicle_Mech, Freighter, Pet, Ship_07, Ship_08,
            Ship_09
        }
        /* 0x0 */ public CustomisationDataTypeEnum CustomisationDataType;
    }
}
