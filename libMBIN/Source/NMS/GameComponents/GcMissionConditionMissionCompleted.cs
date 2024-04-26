namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2997545CCDDD9AC1, NameHash = 0xC28C1E8A4FA47E3B)]
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
