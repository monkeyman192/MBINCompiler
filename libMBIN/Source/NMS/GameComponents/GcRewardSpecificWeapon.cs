using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, Alignment = 0x8, GUID = 0xB0AF508BEC3D9809, NameHash = 0xF3710AB8A6F40A88)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        public GcInventoryContainer WeaponInventory;
        public GcInventoryLayout WeaponLayout;
        public GcExactResource WeaponResource;
        [NMS(Size = 0x20)]
        public string NameOverride;
    }
}
