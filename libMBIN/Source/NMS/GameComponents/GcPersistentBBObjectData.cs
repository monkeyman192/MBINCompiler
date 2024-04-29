namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D7FF833C771C288, NameHash = 0xCD3485C140AE7B57)]
    public class GcPersistentBBObjectData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Vector3f At;
        [NMS(Index = 5)]
        /* 0x10 */ public Vector3f Position;
        [NMS(Index = 6)]
        /* 0x20 */ public Vector3f Up;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 ObjectID;
        [NMS(Index = 2)]
        /* 0x40 */ public ulong GalacticAddress;
        [NMS(Index = 3)]
        /* 0x48 */ public ulong RegionSeed;
        [NMS(Index = 0)]
        /* 0x50 */ public ulong Timestamp;
        [NMS(Index = 4)]
        /* 0x58 */ public ulong UserData;
    }
}
