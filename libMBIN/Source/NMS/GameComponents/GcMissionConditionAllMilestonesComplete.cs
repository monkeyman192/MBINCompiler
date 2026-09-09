namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9B6BF3E61DEA3AA, NameHash = 0xB4AC20F0)]
    public class GcMissionConditionAllMilestonesComplete : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int ForStage;
        [NMS(Index = 2)]
        /* 0x4 */ public bool SubtractOneMilestoneFromTest;
        [NMS(Index = 1)]
        /* 0x5 */ public bool UseSeasonOverrideMessage;
    }
}
