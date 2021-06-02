using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1D0, GUID = 0xAEBC854578DE6E33, NameHash = 0xF4282F250D0EEBDB)]
    public class GcAtlasSendSubmitMonument : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x010 */ public GcAtlasMonument Monument;
		public enum MonumentRolesEnum { Creator, CoCreator }
		/* 0x1A0 */ public MonumentRolesEnum MonumentRoles;
        /* 0x1A4 */ public NMSString0x20 OtherUser;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1C4 */ public byte[] EndPadding;
    }
}
