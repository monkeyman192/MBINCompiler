namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4F01E7B0E9E4931, NameHash = 0xB10B54EF)]
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
