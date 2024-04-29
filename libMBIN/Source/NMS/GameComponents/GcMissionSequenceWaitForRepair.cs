using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE22B97F31004C8A9, NameHash = 0x79652C883CA60AE)]
    public class GcMissionSequenceWaitForRepair : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcStatsTypes TargetStat;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
