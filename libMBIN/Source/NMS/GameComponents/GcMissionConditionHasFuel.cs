using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9138C05BF458F52, NameHash = 0x2A8282CD4FA96596)]
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
