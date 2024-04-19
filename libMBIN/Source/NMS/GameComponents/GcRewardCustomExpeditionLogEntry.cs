namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE978CF26B73E54D, NameHash = 0xF6BA3ABDC071904B)]
    public class GcRewardCustomExpeditionLogEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LocID;
        /* 0x20 */ public NMSString0x10 RewardID;
        /* 0x30 */ public bool FromIntervention;
        /* 0x31 */ public bool WhaleEvent;
    }
}
