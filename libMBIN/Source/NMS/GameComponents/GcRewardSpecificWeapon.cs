using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D84235C2C933B7F, NameHash = 0x5F82FF34)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 5)]
        /* 0x160 */ public NMSString0x20A NameOverride;
        [NMS(Index = 2)]
        /* 0x180 */ public GcExactResource WeaponResource;
        [NMS(Index = 1)]
        /* 0x1A0 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 4)]
        /* 0x1B8 */ public GcInventoryLayoutSizeType InventorySizeOverride;
        [NMS(Index = 3)]
        /* 0x1BC */ public GcWeaponClasses WeaponType;
        [NMS(Index = 8)]
        /* 0x1C0 */ public bool FormatAsSeasonal;
        [NMS(Index = 6)]
        /* 0x1C1 */ public bool IsGift;
        [NMS(Index = 7)]
        /* 0x1C2 */ public bool IsRewardWeapon;
    }
}
