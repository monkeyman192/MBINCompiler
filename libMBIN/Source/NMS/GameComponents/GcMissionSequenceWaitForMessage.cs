using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD0F049A601EDA573, NameHash = 0x768DA5D2543840C5)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string WaitMessageID;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
