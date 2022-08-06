using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8BB6B50446320098, NameHash = 0x49B1F2E8A11B19B6)]
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Item;
        /* 0x090 */ public NMSString0x10 ToBuild;
        /* 0x0A0 */ public bool IsRepair;
        /* 0x0A1 */ public NMSString0x80 DebugText;
    }
}