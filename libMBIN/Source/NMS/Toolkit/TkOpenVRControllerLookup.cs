using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB0, GUID = 0x7543A340714C4A05, NameHash = 0x5AFD5621E9999DDA)]
    public class TkOpenVRControllerLookup : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string DeviceKeywords;
        [NMS(Size = 0x80)]
        public string DeviceSpec;
        [NMS(Size = 0x10)]
        public string ResetVRViewLayerName;
    }
}
