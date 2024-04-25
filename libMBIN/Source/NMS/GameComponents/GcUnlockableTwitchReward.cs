namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7150D917844F3DF, NameHash = 0xE9EC3242091011CC)]
    public class GcUnlockableTwitchReward : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 LinkedGroupId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 ProductId;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 TwitchId;
    }
}
