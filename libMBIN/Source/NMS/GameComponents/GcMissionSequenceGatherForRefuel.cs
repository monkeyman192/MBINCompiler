using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD69BA9541B5C824F, NameHash = 0xDD75E678)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x24 */ public GcStatsTypes TargetStat;
    }
}
