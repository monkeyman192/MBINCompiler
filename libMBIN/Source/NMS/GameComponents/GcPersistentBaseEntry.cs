namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD68C76656337512A, NameHash = 0xD040D4124F0456EF)]
    public class GcPersistentBaseEntry : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector3f At;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector3f Position;
        [NMS(Index = 4)]
        /* 0x20 */ public Vector3f Up;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 ObjectID;
        [NMS(Index = 0)]
        /* 0x40 */ public ulong Timestamp;
        [NMS(Index = 2)]
        /* 0x48 */ public ulong UserData;
        [NMS(Index = 6)]
        /* 0x50 */ public NMSString0x40 Message;
    }
}
