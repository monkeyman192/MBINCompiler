namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17C77D54ACACD0A5, NameHash = 0xE266721D)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool BroadcastInMultiplayer;
    }
}
