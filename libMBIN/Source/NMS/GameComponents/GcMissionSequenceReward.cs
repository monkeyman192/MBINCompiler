using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x118, GUID = 0x20982378EF686841, NameHash = 0x7471FD77815538C2)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Reward;
        /* 0x090 */ public bool CanOverride;
        [NMS(Size = 0x80)]
        /* 0x091 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x111 */ public byte[] EndPadding;
    }
}
