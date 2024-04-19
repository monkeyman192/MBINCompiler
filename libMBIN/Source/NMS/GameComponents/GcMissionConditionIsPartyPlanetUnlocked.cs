namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4577DB384FD71892, NameHash = 0xD08AEA33ACABB2E9)]
    public class GcMissionConditionIsPartyPlanetUnlocked : NMSTemplate
    {
        /* 0x0 */ public int SpecificRendevousPlanetIndex;
        /* 0x4 */ public bool TakeIndexFromMilestoneStage;
        /* 0x5 */ public bool TakeIndexFromSeasonData;
    }
}
