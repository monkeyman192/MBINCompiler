using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA60747DE40AB1CA5, NameHash = 0xBD4D110E1D076CE)]
    public class GcAtlasMonument : NMSTemplate
    {
        /* 0x000 */ public Vector3f At;
        /* 0x010 */ public Vector3f Position;
        /* 0x020 */ public ulong Timestamp;
        /* 0x028 */ public GcUniverseAddressData UniverseAddress;
        /* 0x040 */ public NMSString0x40 CocreatorName;
        /* 0x080 */ public NMSString0x40 CocreatorOnlineID;
        /* 0x0C0 */ public NMSString0x40 CreatorName;
        /* 0x100 */ public NMSString0x40 CreatorOnlineID;
        /* 0x140 */ public NMSString0x40 RID;
    }
}
