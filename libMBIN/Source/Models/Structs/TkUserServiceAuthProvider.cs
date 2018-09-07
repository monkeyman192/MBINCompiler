namespace libMBIN.Models.Structs
{
    public class TkUserServiceAuthProvider : NMSTemplate
    {
		public enum AuthProviderEnum { Null, PSN, Steam, Galaxy }
		public AuthProviderEnum AuthProvider;
    }
}
