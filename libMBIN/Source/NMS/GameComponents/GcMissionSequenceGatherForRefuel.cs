using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7BFBD03B88CC4405, NameHash = 0x9FA5A1E5E026A5B3)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        /* 0x084 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
