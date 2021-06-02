using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0x59E934EAC79B537E, NameHash = 0x9FA5A1E5E026A5B3)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        /* 0x084 */ public int Amount;
        /* 0x088 */ public NMSString0x80 DebugText;
    }
}
