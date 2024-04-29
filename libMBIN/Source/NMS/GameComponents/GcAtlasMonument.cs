using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3C47A4D7143D624, NameHash = 0xBD4D110E1D076CE)]
    public class GcAtlasMonument : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public Vector3f At;
        [NMS(Index = 1)]
        /* 0x010 */ public Vector3f Position;
        [NMS(Index = 8)]
        /* 0x020 */ public ulong Timestamp;
        [NMS(Index = 0)]
        /* 0x028 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 6)]
        /* 0x040 */ public NMSString0x40 CocreatorName;
        [NMS(Index = 7)]
        /* 0x080 */ public NMSString0x40 CocreatorOnlineID;
        [NMS(Index = 4)]
        /* 0x0C0 */ public NMSString0x40 CreatorName;
        [NMS(Index = 5)]
        /* 0x100 */ public NMSString0x40 CreatorOnlineID;
        [NMS(Index = 3)]
        /* 0x140 */ public NMSString0x40 RID;
    }
}
