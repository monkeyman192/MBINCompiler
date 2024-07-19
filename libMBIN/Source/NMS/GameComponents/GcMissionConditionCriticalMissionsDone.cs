namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BDF8240A1BE8ADF, NameHash = 0x76BBEA43)]
    public class GcMissionConditionCriticalMissionsDone : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public bool OnlyCheckSeasonalCriticals;
        [NMS(Index = 0)]
        /* 0x1 */ public bool Warped;
    }
}
