using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7137E0498FD3E4D2, NameHash = 0xCFB91CCA40995CDC)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
        // size: 0x22
        public enum SizeTypeEnum { SciSmall, SciMedium, SciLarge, FgtSmall, FgtMedium, FgtLarge, ShuSmall, ShtMedium,
            ShtLarge, DrpSmall, DrpMedium, DrpLarge, RoySmall, RoyMedium,
            RoyLarge, AlienSmall, AlienMedium, AlienLarge, SailSmall, SailMedium,
            SailLarge, WeaponSmall, WeaponMedium, WeaponLarge, FreighterSmall, FreighterMedium,
            FreighterLarge, VehicleSmall, VehicleMedium, VehicleLarge,
            ChestSmall, ChestMedium, ChestLarge, ChestCapsule
        }
        /* 0x0 */ public SizeTypeEnum SizeType;
    }
}
