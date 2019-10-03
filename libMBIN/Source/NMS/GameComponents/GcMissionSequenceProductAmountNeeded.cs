using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8BB6B50446320098, NameHash = 0x49B1F2E8A11B19B6)]
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Item;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string ToBuild;
        /* 0x0A0 */ public bool IsRepair;
        [NMS(Size = 0x80)]
        /* 0x0A1 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x121 */ public byte[] Endpadding;
    }
}
