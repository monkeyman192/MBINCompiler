namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x58E4F308E63BA84A, NameHash = 0xC728D4342BAC4AC8)]
    public class TkPlatformButtonPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ButtonId;
        /* 0x10 */ public NMSString0x10 PlatformId;
        /* 0x20 */ public Vector2f Size;
    }
}
