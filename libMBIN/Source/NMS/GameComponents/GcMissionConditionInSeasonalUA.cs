namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE56B9FAF2C3575E4, NameHash = 0x15FCC555BAF3FC21)]
    public class GcMissionConditionInSeasonalUA : NMSTemplate
    {
        /* 0x0 */ public int SpecificRendevousPlanetIndex;
        /* 0x4 */ public bool CompleteIfRendezvousDone;
        /* 0x5 */ public bool SpecificIndexOnlyNeedsToMatchSystem;
        /* 0x6 */ public bool TakeIndexFromMilestoneStage;
        /* 0x7 */ public bool TakeIndexFromSeasonData;
    }
}
