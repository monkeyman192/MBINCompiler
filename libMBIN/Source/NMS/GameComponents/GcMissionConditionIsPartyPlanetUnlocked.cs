namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAB1829874BEF429, NameHash = 0x5E10F1FF)]
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
