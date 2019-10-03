using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0x7C4CB3CB26C66166, NameHash = 0xFFDCD21B79EE81DE)]
    public class GcScreenFilterData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string LocText;
        [NMS(Size = 0x80)]
        public string Filename;
        public float FadeDistance;
        public bool SelectableInPhotoMode;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
