using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5C2AD9EDC86BBE93, NameHash = 0xE3C593A400EF084C)]
    public class GcInventoryType : NMSTemplate
    {
		public enum InventoryTypeEnum { Substance, Technology, Product }
		public InventoryTypeEnum InventoryType;
    }
}