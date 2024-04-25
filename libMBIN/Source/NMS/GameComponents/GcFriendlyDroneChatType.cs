namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x616AD1CA5E74AA15, NameHash = 0x6E9F63DB3D3055)]
    public class GcFriendlyDroneChatType : NMSTemplate
    {
        // size: 0x5
        public enum FriendlyDroneChatTypeEnum : uint {
            Summoned,
            Unsummoned,
            BecomeWanted,
            LoseWanted,
            Idle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FriendlyDroneChatTypeEnum FriendlyDroneChatType;
    }
}
