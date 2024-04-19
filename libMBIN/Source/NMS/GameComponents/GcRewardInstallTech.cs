namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8394A683A8878273, NameHash = 0x75DF796697F3DB0A)]
    public class GcRewardInstallTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ReplaceExistingTech;
        /* 0x10 */ public NMSString0x10 TechId;
        // size: 0x7
        public enum InventoryToInstallInEnum : uint {
            Personal,
            PersonalTech,
            Ship,
            ShipTech,
            Freighter,
            Vehicle,
            Weapon,
        }
        /* 0x20 */ public InventoryToInstallInEnum InventoryToInstallIn;
        /* 0x24 */ public bool InstallBroken;
        /* 0x25 */ public bool Silent;
    }
}
