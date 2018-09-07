namespace libMBIN.Models.Structs
{
    public class GcInventorySpecialSlotType : NMSTemplate
    {
		public enum InventorySpecialSlotTypeEnum { Broken, TechOnly, Cargo }
		public InventorySpecialSlotTypeEnum InventorySpecialSlotType;
    }
}
