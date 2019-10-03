using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x42D5E0C093493E60, NameHash = 0x5C2C30D664D4775B)]
    public class GcInventoryClass : NMSTemplate
    {
		public enum InventoryClassEnum { C, B, A, S }
		public InventoryClassEnum InventoryClass;
    }
}
