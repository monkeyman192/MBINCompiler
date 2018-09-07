namespace libMBIN.Models.Structs
{
    public class GcInventoryType : NMSTemplate
    {
		public enum InventoryTypeEnum { Substance, Technology, Product }
		public InventoryTypeEnum InventoryType;
    }
}
