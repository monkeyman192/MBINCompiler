namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6E559B5303AE6CD, NameHash = 0xB7AA58E3)]
    public class GcRewardCustomExpeditionLogEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A LocID;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 RewardID;
        [NMS(Index = 0)]
        /* 0x30 */ public bool FromIntervention;
        [NMS(Index = 1)]
        /* 0x31 */ public bool WhaleEvent;
    }
}
