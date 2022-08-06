using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x827E6A373F76323C, NameHash = 0x75DF796697F3DB0A)]
    public class GcRewardInstallTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TechId;
        // size: 0x7
        public enum InventoryToInstallInEnum { Personal, PersonalTech, Ship, ShipTech, Freighter, Vehicle, Weapon }
        /* 0x10 */ public InventoryToInstallInEnum InventoryToInstallIn;
        /* 0x14 */ public bool Silent;
        /* 0x15 */ public bool InstallBroken;
    }
}
