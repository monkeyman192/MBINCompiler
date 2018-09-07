namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x150)]
    public class GcAtlasSendSubmitMonument : NMSTemplate
    {
        ///* 0x000 */ public sub_1404777E0 ClientUserData;
        ///* 0x010 */ public sub_140482DC0 Monument;
        /* 0x120 */ public int MonumentRole;
		public enum MonumentRolesEnum { Creator, CoCreator }
		public MonumentRolesEnum MonumentRoles;
        [NMS(Size = 0x20)]
        /* 0x124 */ public string OtherUser;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x144 */ public byte[] EndPadding;
    }
}
