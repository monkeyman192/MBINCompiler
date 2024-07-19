namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7119B895413DD133, NameHash = 0xE98A05A5)]
    public class GcFontData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString File;
        [NMS(Index = 1)]
        /* 0x10 */ public int MinCharWidth;
    }
}
