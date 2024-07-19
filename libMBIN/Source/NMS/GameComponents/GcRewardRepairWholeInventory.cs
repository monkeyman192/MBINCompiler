namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B12A7765BF54C2D, NameHash = 0xE7A841F6)]
    public class GcRewardRepairWholeInventory : NMSTemplate
    {
        // size: 0x8
        public enum InventoryToRepairEnum : uint {
            Personal,
            PersonalTech,
            Ship,
            ShipTech,
            Freighter,
            Vehicle,
            AttachedAbandonedShip,
            Weapon,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryToRepairEnum InventoryToRepair;
    }
}
