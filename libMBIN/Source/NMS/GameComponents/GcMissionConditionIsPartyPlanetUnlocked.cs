namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4577DB384FD71892, NameHash = 0xD08AEA33ACABB2E9)]
    public class GcMissionConditionIsPartyPlanetUnlocked : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int SpecificRendevousPlanetIndex;
        [NMS(Index = 2)]
        /* 0x4 */ public bool TakeIndexFromMilestoneStage;
        [NMS(Index = 1)]
        /* 0x5 */ public bool TakeIndexFromSeasonData;
    }
}
