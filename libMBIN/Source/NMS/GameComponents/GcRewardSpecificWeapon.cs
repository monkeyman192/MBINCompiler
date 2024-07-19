using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76D32443B0FA3D72, NameHash = 0x5F82FF34)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 5)]
        /* 0x158 */ public NMSString0x20A NameOverride;
        [NMS(Index = 2)]
        /* 0x178 */ public GcExactResource WeaponResource;
        [NMS(Index = 1)]
        /* 0x198 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 4)]
        /* 0x1B0 */ public GcInventoryLayoutSizeType InventorySizeOverride;
        [NMS(Index = 3)]
        /* 0x1B4 */ public GcWeaponClasses WeaponType;
        [NMS(Index = 8)]
        /* 0x1B8 */ public bool FormatAsSeasonal;
        [NMS(Index = 6)]
        /* 0x1B9 */ public bool IsGift;
        [NMS(Index = 7)]
        /* 0x1BA */ public bool IsRewardWeapon;
    }
}
