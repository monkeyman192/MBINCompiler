using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4001A0B36B928FE0, NameHash = 0x88CFB7D1D223D0C5)]
    public class GcHUDTextData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcTextPreset Preset;
        [NMS(Index = 0)]
        /* 0x70 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x98 */ public NMSString0x80 Text;
    }
}
