namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7EAEBFC53D8634E2, NameHash = 0x15FCC555BAF3FC21)]
    public class GcMissionConditionInSeasonalUA : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int SpecificRendevousPlanetIndex;
        [NMS(Index = 4)]
        /* 0x4 */ public bool CompleteIfRendezvousDone;
        [NMS(Index = 1)]
        /* 0x5 */ public bool SpecificIndexOnlyNeedsToMatchSystem;
        [NMS(Index = 3)]
        /* 0x6 */ public bool TakeIndexFromMilestoneStage;
        [NMS(Index = 2)]
        /* 0x7 */ public bool TakeIndexFromSeasonData;
    }
}
