namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F2A0028EB68077A, NameHash = 0x75DF796697F3DB0A)]
    public class GcRewardInstallTech : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 ReplaceExistingTech;
        [NMS(Index = 0)]
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
        [NMS(Index = 2)]
        /* 0x20 */ public InventoryToInstallInEnum InventoryToInstallIn;
        [NMS(Index = 4)]
        /* 0x24 */ public bool InstallBroken;
        [NMS(Index = 3)]
        /* 0x25 */ public bool Silent;
    }
}
