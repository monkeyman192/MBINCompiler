using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBCCCC590A7D7EF26, NameHash = 0x8A37C4A2)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 1)]
        /* 0x160 */ public GcCharacterCustomisationData Customisation;
        [NMS(Index = 0)]
        /* 0x1B8 */ public GcResourceElement ShipResource;
        [NMS(Index = 9)]
        /* 0x200 */ public NMSString0x20A NameOverride;
        [NMS(Index = 2)]
        /* 0x220 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 4)]
        /* 0x238 */ public int CostAmount;
        [NMS(Index = 5)]
        /* 0x23C */ public GcCurrency CostCurrency;
        [NMS(Index = 13)]
        /* 0x240 */ public GcModelViews ModelViewOverride;
        [NMS(Index = 8)]
        /* 0x244 */ public GcInventoryLayoutSizeType OverrideSizeType;
        [NMS(Index = 6)]
        /* 0x248 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 12)]
        /* 0x24C */ public bool FormatAsSeasonal;
        [NMS(Index = 10)]
        /* 0x24D */ public bool IsGift;
        [NMS(Index = 11)]
        /* 0x24E */ public bool IsRewardShip;
        [NMS(Index = 7)]
        /* 0x24F */ public bool UseOverrideSizeType;
    }
}
