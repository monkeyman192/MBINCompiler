namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4466DA55A3C74D9F, NameHash = 0x67952ED4)]
    public class TkControllerButtonLookup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString ButtonImageLookupFilename;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
    }
}
