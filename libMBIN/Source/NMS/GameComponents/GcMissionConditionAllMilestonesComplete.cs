namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE7B315BA42BABE5, NameHash = 0x88DB4BD2401DF5D)]
    public class GcMissionConditionAllMilestonesComplete : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int ForStage;
        [NMS(Index = 1)]
        /* 0x4 */ public bool UseSeasonOverrideMessage;
    }
}
