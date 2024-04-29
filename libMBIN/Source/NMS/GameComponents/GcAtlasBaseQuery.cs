using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3ACCE8A58EF75C40, NameHash = 0xC263B56059CD6513)]
    public class GcAtlasBaseQuery : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 1)]
        /* 0x28 */ public GcGameMode GameMode;
        [NMS(Index = 2)]
        /* 0x2C */ public NMSString0x20 UserId;
    }
}
