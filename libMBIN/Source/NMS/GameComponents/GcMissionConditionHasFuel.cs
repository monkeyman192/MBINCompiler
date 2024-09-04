using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x247BE8067A7CC8AF, NameHash = 0x5916A21F)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 SpecificTechID;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x14 */ public GcStatsTypes TargetStat;
        [NMS(Index = 3)]
        /* 0x18 */ public bool FormatTextAsPercentage;
    }
}
