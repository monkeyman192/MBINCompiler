using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20A333130579E3E8, NameHash = 0x798B3001AC5A7114)]
    public class GcMissionConditionWeaponMode : NMSTemplate
    {
        /* 0x0 */ public GcPlayerWeapons WeaponMode;
    }
}
