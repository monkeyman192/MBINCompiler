namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6422064EFC3EF8F0, NameHash = 0x1FC4AFB61328FD1E)]
    public class TkControllerButtonLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x80 ButtonImageLookupFilename;
    }
}
