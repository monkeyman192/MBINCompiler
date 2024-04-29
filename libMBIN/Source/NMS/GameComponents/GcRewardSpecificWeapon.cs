using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDD12F1FCFD5A5D0, NameHash = 0xF3710AB8A6F40A88)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 2)]
        /* 0x158 */ public GcExactResource WeaponResource;
        [NMS(Index = 5)]
        /* 0x1E8 */ public NMSString0x20A NameOverride;
        [NMS(Index = 1)]
        /* 0x208 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 4)]
        /* 0x220 */ public GcInventoryLayoutSizeType InventorySizeOverride;
        [NMS(Index = 3)]
        /* 0x224 */ public GcWeaponClasses WeaponType;
        [NMS(Index = 8)]
        /* 0x228 */ public bool FormatAsSeasonal;
        [NMS(Index = 6)]
        /* 0x229 */ public bool IsGift;
        [NMS(Index = 7)]
        /* 0x22A */ public bool IsRewardWeapon;
    }
}
