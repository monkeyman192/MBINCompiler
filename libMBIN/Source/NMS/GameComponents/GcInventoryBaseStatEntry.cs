using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC377F0E807316984, NameHash = 0x706BDD46AD2006F7)]
    public class GcInventoryBaseStatEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BaseStatID;
        /* 0x10 */ public float Value;
    }
}