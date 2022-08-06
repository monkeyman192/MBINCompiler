using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA597009186A79B85, NameHash = 0x0B0C58666F58DF1C)]
    public class GcRewardRepairWholeInventory : NMSTemplate
    {
        public enum InventoryToRepairEnum { Personal, PersonalTech, Ship, ShipTech, Freighter, Vehicle, AttachedAbandonedShip, Weapon }
        public InventoryToRepairEnum InventoryToRepair;
    }
}
