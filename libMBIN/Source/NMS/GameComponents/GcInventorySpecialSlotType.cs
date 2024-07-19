namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB249CC7F519AAE0D, NameHash = 0x10FF2A9F)]
    public class GcInventorySpecialSlotType : NMSTemplate
    {
        // size: 0x5
        public enum InventorySpecialSlotTypeEnum : uint {
            Broken,
            TechOnly,
            Cargo,
            BlockedByBrokenTech,
            TechBonus,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventorySpecialSlotTypeEnum InventorySpecialSlotType;
    }
}
