using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3CB570D765D079, NameHash = 0xC263B56059CD6513)]
    public class GcAtlasBaseQuery : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
        /* 0x28 */ public GcGameMode GameMode;
        /* 0x2C */ public NMSString0x20 UserId;
    }
}
