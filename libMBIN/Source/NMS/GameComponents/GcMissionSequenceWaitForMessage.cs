using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, Alignment = 0x8, GUID = 0xD0F049A601EDA573, NameHash = 0x768DA5D2543840C5)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 WaitMessageID;
        /* 0x090 */ public NMSString0x80 DebugText;
    }
}
