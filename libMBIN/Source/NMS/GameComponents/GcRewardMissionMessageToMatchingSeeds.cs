namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC89FD031D987DE0C, NameHash = 0x9688A6EC7C08672F)]
    public class GcRewardMissionMessageToMatchingSeeds : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool BroadcastInMultiplayer;
    }
}
