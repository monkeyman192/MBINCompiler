using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0x5DC16B88CB9738E7, NameHash = 0x79652C883CA60AE)]
    public class GcMissionSequenceWaitForRepair : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
