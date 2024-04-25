using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F9DB9C05C9E21C0, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcResourceElement ShipResource;
        [NMS(Index = 2)]
        /* 0x2A8 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 8)]
        /* 0x400 */ public NMSString0x20A NameOverride;
        [NMS(Index = 1)]
        /* 0x420 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 3)]
        /* 0x438 */ public int CostAmount;
        [NMS(Index = 4)]
        /* 0x43C */ public GcCurrency CostCurrency;
        [NMS(Index = 7)]
        /* 0x440 */ public GcInventoryLayoutSizeType OverrideSizeType;
        [NMS(Index = 5)]
        /* 0x444 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 11)]
        /* 0x448 */ public bool FormatAsSeasonal;
        [NMS(Index = 9)]
        /* 0x449 */ public bool IsGift;
        [NMS(Index = 10)]
        /* 0x44A */ public bool IsRewardShip;
        [NMS(Index = 6)]
        /* 0x44B */ public bool UseOverrideSizeType;
    }
}
