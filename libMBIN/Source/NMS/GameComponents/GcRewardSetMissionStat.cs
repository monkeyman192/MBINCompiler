namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89D98C0756B3481C, NameHash = 0xEA1D610873C9E66B)]
    public class GcRewardSetMissionStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int ValueToAdd;
        [NMS(Index = 0)]
        /* 0x4 */ public int ValueToSet;
    }
}
