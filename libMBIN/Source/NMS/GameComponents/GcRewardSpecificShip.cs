using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEAEE580BDAB396A, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcResourceElement ShipResource;
        [NMS(Index = 3)]
        /* 0x2A8 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 1)]
        /* 0x400 */ public GcCharacterCustomisationData Customisation;
        [NMS(Index = 9)]
        /* 0x458 */ public NMSString0x20A NameOverride;
        [NMS(Index = 2)]
        /* 0x478 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 4)]
        /* 0x490 */ public int CostAmount;
        [NMS(Index = 5)]
        /* 0x494 */ public GcCurrency CostCurrency;
        [NMS(Index = 8)]
        /* 0x498 */ public GcInventoryLayoutSizeType OverrideSizeType;
        [NMS(Index = 6)]
        /* 0x49C */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 12)]
        /* 0x4A0 */ public bool FormatAsSeasonal;
        [NMS(Index = 10)]
        /* 0x4A1 */ public bool IsGift;
        [NMS(Index = 11)]
        /* 0x4A2 */ public bool IsRewardShip;
        [NMS(Index = 7)]
        /* 0x4A3 */ public bool UseOverrideSizeType;
    }
}
