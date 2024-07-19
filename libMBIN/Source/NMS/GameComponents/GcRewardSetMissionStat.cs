namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A188F59081A74C8, NameHash = 0x2CEF47EC)]
    public class GcRewardSetMissionStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int ValueToAdd;
        [NMS(Index = 0)]
        /* 0x4 */ public int ValueToSet;
    }
}
