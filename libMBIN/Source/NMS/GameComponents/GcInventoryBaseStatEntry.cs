using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xC377F0E807316984, NameHash = 0x706BDD46AD2006F7)]
    public class GcInventoryBaseStatEntry : NMSTemplate
    {
        public NMSString0x10 BaseStatID;
        public float Value;
    }
}