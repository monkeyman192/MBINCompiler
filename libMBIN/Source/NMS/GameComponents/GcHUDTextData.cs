using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EF3CBDD0A950DED, NameHash = 0x88CFB7D1D223D0C5)]
    public class GcHUDTextData : NMSTemplate
    {
        /* 0x00 */ public GcTextPreset Preset;
        /* 0x70 */ public GcHUDComponent Data;
        /* 0x98 */ public NMSString0x80 Text;
    }
}
