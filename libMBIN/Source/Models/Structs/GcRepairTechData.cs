namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class GcRepairTechData : NMSTemplate
    {
        public GcMaintenanceContainer MaintenanceContainer;
        public int InventoryType;
        public GcInventoryIndex InventoryIndex;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
