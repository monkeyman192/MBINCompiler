using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x240, Alignment = 0x8, GUID = 0x4450E4878E977D89, NameHash = 0xF3710AB8A6F40A88)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer WeaponInventory;
        /* 0x160 */ public GcInventoryLayout WeaponLayout;
        /* 0x180 */ public GcExactResource WeaponResource;
        /* 0x210 */ public GcWeaponClasses WeaponType;
        /* 0x218 */ public NMSString0x20A NameOverride;
        /* 0x238 */ public bool IsGift;
        /* 0x239 */ public bool IsRewardWeapon;
        /* 0x23A */ public bool FormatAsSeasonal;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x23B */ public byte[] EndPadding;
    }
}
