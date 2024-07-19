namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57DED3CFF0EFEFEB, NameHash = 0xADA5A448)]
    public class GcNPCInteractiveObjectType : NMSTemplate
    {
        // size: 0x8
        public enum NPCInteractiveObjectTypeEnum : uint {
            Idle,
            Generic,
            Chair,
            Conversation,
            WatchShip,
            Shop,
            Dance,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCInteractiveObjectTypeEnum NPCInteractiveObjectType;
    }
}
