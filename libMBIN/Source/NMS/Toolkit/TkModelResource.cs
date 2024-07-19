namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE51AD91853C53588, NameHash = 0x2232E698)]
    public class TkModelResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcResource ResHandle;
    }
}
