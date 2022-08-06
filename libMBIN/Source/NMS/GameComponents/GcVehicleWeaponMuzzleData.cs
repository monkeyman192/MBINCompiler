using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43E398D1351FF5BE, NameHash = 0x14D89D4646100892)]
    public class GcVehicleWeaponMuzzleData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 MuzzleFlashEffect;
    }
}
