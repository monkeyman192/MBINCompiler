using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1779D4E78CAA8C32, NameHash = 0xE3BDE57931D2177D)]
    public class GcVehicleWeaponMode : NMSTemplate
    {
        // size: 0x4
        public enum VehicleWeaponModeEnum { Laser, Gun, TerrainEdit, StunGun }
        /* 0x0 */ public VehicleWeaponModeEnum VehicleWeaponMode;
    }
}
