namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57DED3CFF0EFEFEB, NameHash = 0x6C6EDC3D5C0DA932)]
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
