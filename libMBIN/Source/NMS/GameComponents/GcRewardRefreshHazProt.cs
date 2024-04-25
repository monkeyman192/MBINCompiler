namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7556032DAD186762, NameHash = 0xA8C5FB6413CFB7AA)]
    public class GcRewardRefreshHazProt : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Amount;
        [NMS(Index = 1)]
        /* 0x4 */ public bool SetNotAdd;
        [NMS(Index = 2)]
        /* 0x5 */ public bool Silent;
    }
}
