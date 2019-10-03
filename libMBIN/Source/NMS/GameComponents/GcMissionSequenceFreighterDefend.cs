using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x34859B54B290BBF3, NameHash = 0xF36BE6D70F8873E4)]
    public class GcMissionSequenceFreighterDefend : NMSTemplate      // size: 0x100
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
