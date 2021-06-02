using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0xDF3A7624A71B6C10, NameHash = 0x9DE374680DE23364)]
    public class GcMissionSequenceGetUnitsToBuyItem : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Item;
        /* 0x090 */ public NMSString0x80 DebugText;
    }
}