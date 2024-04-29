namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x439B313227A2A020, NameHash = 0xB9BE65CA55BBE004)]
    public class GcRewardHazard : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x8 */ public bool Silent;
    }
}
