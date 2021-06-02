using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB0, GUID = 0x7543A340714C4A05, NameHash = 0x5AFD5621E9999DDA)]
    public class TkOpenVRControllerLookup : NMSTemplate
    {
        public NMSString0x20 DeviceKeywords;
        public NMSString0x80 DeviceSpec;
        public NMSString0x10 ResetVRViewLayerName;
    }
}
