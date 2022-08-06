using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26B1923F6B885761, NameHash = 0xC1BA164E8D33C80A)]
    public class GcWeaponInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        public int[] MaxInventoryCapacity;
    }
}
