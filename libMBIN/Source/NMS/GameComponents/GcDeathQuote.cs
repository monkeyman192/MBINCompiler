namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC3FF810BBEE79F9, NameHash = 0xF995C127)]
    public class GcDeathQuote : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x80 QuoteLine1;
        [NMS(Index = 1)]
        /* 0x080 */ public NMSString0x80 QuoteLine2;
        [NMS(Index = 2)]
        /* 0x100 */ public NMSString0x20 Author;
    }
}
