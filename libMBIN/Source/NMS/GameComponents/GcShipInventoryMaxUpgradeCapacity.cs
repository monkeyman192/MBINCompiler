using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CCE7F992A936F32, NameHash = 0xC51C8A0A49F892DC)]
    public class GcShipInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x00 */ public int[] MaxInventoryCapacity;
        [NMS(Size = 0x4)]
        /* 0x10 */ public int[] MaxTechInventoryCapacity;
        [NMS(Size = 0x4)]
        /* 0x20 */ public int[] MaxCargoInventoryCapacity;
    }
}
