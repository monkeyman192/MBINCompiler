using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x2321BBFA99AD8E43, NameHash = 0xC263B56059CD6513)]
    public class GcAtlasBaseQuery : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x18 */ public GcGameMode GameMode;
        [NMS(Size = 0x20)]
        /* 0x1C */ public string UserId;
        /* 0x40 */ public Vector3f Position;
    }
}
