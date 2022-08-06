using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25CDC540F8CBEBCF, NameHash = 0xD46635882CF8E5)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        public NMSString0x10 ID;
        public GcInventoryType InventoryType;
        public int Amount;
    }
}
