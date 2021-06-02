using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0xCFC9CC53C7F79504, NameHash = 0x25696B35BE341F6C)]
    public class GcMissionSequenceWaitForRefuel : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        /* 0x084 */ public int Amount;
        /* 0x088 */ public NMSString0x80 DebugText;
    }
}
