namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE76FBE3B577BFB0F, NameHash = 0xCAEF37A4)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MissionID;
        [NMS(Index = 4)]
        /* 0x10 */ public int CalculateSeasonalSeedFromStageIndexOffset;
        [NMS(Index = 1)]
        /* 0x14 */ public int SeasonalMissionSeed;
        [NMS(Index = 3)]
        /* 0x18 */ public bool CalculateTextMissionTargetFromStageIndex;
        [NMS(Index = 2)]
        /* 0x19 */ public bool TakeIDFromSeasonData;
    }
}
