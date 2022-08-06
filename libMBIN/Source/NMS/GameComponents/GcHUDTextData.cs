using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x738CDF94ACD0CC0A, NameHash = 0x88CFB7D1D223D0C5)]
    public class GcHUDTextData : NMSTemplate
    {
        public GcHUDComponent Data;

        public NMSString0x80 Text;

        public GcTextPreset Preset;
    }
}