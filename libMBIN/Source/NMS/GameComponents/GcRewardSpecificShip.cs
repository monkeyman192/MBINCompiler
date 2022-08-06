using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31E9F07A286067C1, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ShipResource;
        /* 0x2A8 */ public GcInventoryLayout ShipLayout;
        /* 0x2C8 */ public GcInventoryContainer ShipInventory;
        /* 0x428 */ public GcSpaceshipClasses ShipType;
        /* 0x430 */ public NMSString0x20A NameOverride;
        /* 0x450 */ public bool IsGift;
        /* 0x451 */ public bool IsRewardShip;
        /* 0x452 */ public bool FormatAsSeasonal;
    }
}
