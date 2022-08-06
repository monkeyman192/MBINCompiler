using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A2E0608F3F962B9, NameHash = 0xB40BD8EC092ACF02)]
    public class GcPlayerControlModeEntry : NMSTemplate
    {
        public NMSString0x10 Id;
        public TkModelResource ControlModeResource;
    }
}
