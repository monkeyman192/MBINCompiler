namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE143B09D707BBE56, NameHash = 0xEA5D5BE5)]
    public class TkTextureResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcResource ResHandle;
    }
}
