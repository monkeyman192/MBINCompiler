using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1D0, GUID = 0xAE2027400EC63932, NameHash = 0xF4282F250D0EEBDB)]
    public class GcAtlasSendSubmitMonument : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public GcAtlasMonument Monument;
		public enum MonumentRolesEnum { Creator, CoCreator }
		/* 0x1A0 */ public MonumentRolesEnum MonumentRoles;
        [NMS(Size = 0x20)]
        /* 0x1A4 */ public string OtherUser;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1C4 */ public byte[] EndPadding;
    }
}
