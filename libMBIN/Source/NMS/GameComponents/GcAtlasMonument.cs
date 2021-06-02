using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0x6845EF170C6FF29B, NameHash = 0xBD4D110E1D076CE)]
    public class GcAtlasMonument : NMSTemplate
    {
        /* 0x000 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x018 */ public byte[] Padding18;
        /* 0x020 */ public Vector4f Position;
        /* 0x030 */ public Vector4f At;
        /* 0x040 */ public NMSString0x40 RID;
        /* 0x080 */ public NMSString0x40 CreatorName;
        /* 0x0C0 */ public NMSString0x40 CreatorOnlineID;
        /* 0x100 */ public NMSString0x40 CocreatorName;
        /* 0x140 */ public NMSString0x40 CocreatorOnlineID;
        /* 0x180 */ public ulong Timestamp;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
