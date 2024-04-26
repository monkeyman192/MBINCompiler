namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB263B36D3FD7ECAC, NameHash = 0x489841A427B2161E)]
    public class GcInventoryStackSizeGroup : NMSTemplate
    {
        // size: 0xD
        public enum InventoryStackSizeGroupEnum : uint {
            Default,
            Personal,
            PersonalCargo,
            Ship,
            ShipCargo,
            Freighter,
            FreighterCargo,
            Vehicle,
            Chest,
            BaseCapsule,
            MaintenanceObject,
            UIPopup,
            SeasonTransfer,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryStackSizeGroupEnum InventoryStackSizeGroup;
    }
}
