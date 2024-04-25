using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5862A7824BC09E0, NameHash = 0x7798386870FA1776)]
    public class GcSaveContextDataMaskTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSaveContextDataMask Mask;
    }
}
