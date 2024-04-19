using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F9DB9C05C9E21C0, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ShipResource;
        /* 0x2A8 */ public GcInventoryContainer ShipInventory;
        /* 0x400 */ public NMSString0x20A NameOverride;
        /* 0x420 */ public GcInventoryLayout ShipLayout;
        /* 0x438 */ public int CostAmount;
        /* 0x43C */ public GcCurrency CostCurrency;
        /* 0x440 */ public GcInventoryLayoutSizeType OverrideSizeType;
        /* 0x444 */ public GcSpaceshipClasses ShipType;
        /* 0x448 */ public bool FormatAsSeasonal;
        /* 0x449 */ public bool IsGift;
        /* 0x44A */ public bool IsRewardShip;
        /* 0x44B */ public bool UseOverrideSizeType;
    }
}
