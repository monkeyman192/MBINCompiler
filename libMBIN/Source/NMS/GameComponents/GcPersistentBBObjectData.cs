namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAD41A8138D2B51E, NameHash = 0xCD3485C140AE7B57)]
    public class GcPersistentBBObjectData : NMSTemplate
    {
        /* 0x00 */ public Vector3f At;
        /* 0x10 */ public Vector3f Position;
        /* 0x20 */ public Vector3f Up;
        /* 0x30 */ public NMSString0x10 ObjectID;
        /* 0x40 */ public ulong GalacticAddress;
        /* 0x48 */ public ulong RegionSeed;
        /* 0x50 */ public ulong Timestamp;
        /* 0x58 */ public ulong UserData;
    }
}
