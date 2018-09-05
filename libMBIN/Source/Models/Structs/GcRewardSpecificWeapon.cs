namespace libMBIN.Models.Structs
{
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        public GcInventoryContainer WeaponInventory;
        public GcInventoryLayout WeaponLayout;
        public GcExactResource WeaponResource;
        [NMS(Size = 0x20)]
        public string NameOverride;
    }
}
