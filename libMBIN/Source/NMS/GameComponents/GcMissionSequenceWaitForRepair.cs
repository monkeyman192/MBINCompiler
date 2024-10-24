using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA06399DB75AAF56, NameHash = 0xE170E56E)]
    public class GcMissionSequenceWaitForRepair : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public GcStatsTypes TargetStat;
    }
}
