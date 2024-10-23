using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA35C74D009623D0F, NameHash = 0x4E83FFA1)]
    public class GcMissionSequenceGatherForRepair : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 GatherResource;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public GcStatsTypes TargetStat;
    }
}
