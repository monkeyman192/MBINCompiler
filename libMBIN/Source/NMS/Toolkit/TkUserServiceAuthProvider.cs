using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xD03F6F0863C69B0F, NameHash = 0x91EF3068AEC32FB7)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
		public enum AuthProviderEnum { Null, PSN, Steam, Galaxy, Xbox, WeGame }
		public AuthProviderEnum AuthProvider;
    }
}
