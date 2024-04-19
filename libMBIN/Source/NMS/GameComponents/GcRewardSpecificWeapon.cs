using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEDFABCF71B2B250, NameHash = 0xF3710AB8A6F40A88)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer WeaponInventory;
        /* 0x158 */ public GcExactResource WeaponResource;
        /* 0x1E8 */ public NMSString0x20A NameOverride;
        /* 0x208 */ public GcInventoryLayout WeaponLayout;
        /* 0x220 */ public GcInventoryLayoutSizeType InventorySizeOverride;
        /* 0x224 */ public GcWeaponClasses WeaponType;
        /* 0x228 */ public bool FormatAsSeasonal;
        /* 0x229 */ public bool IsGift;
        /* 0x22A */ public bool IsRewardWeapon;
    }
}
