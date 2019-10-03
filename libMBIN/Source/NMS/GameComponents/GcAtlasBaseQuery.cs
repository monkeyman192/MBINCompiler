using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x68AF0FDA00EE9F73, NameHash = 0xC263B56059CD6513)]
    public class GcAtlasBaseQuery : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        public GcGameMode GameMode;
        [NMS(Size = 0x20)]
        public string UserId;
        public Vector3f Position;
    }
}
