namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5D934A889912272A, NameHash = 0x91EF3068AEC32FB7)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
        // size: 0x8
        public enum AuthProviderEnum : uint {
            Null,
            PSN,
            Steam,
            Galaxy,
            Xbox,
            WeGame,
            NSO,
            GameCenter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AuthProviderEnum AuthProvider;
    }
}
