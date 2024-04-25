namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE59BB2A26692628, NameHash = 0x4DAD27EBAC31EC8)]
    public class GcMissionConditionCriticalMissionsDone : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public bool OnlyCheckSeasonalCriticals;
        [NMS(Index = 0)]
        /* 0x1 */ public bool Warped;
    }
}
