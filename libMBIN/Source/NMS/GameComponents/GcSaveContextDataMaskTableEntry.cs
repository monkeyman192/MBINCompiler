using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5DCD55BFBF189DD, NameHash = 0xF7B5EADF)]
    public class GcSaveContextDataMaskTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSaveContextDataMask Mask;
    }
}
