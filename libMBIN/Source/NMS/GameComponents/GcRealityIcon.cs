using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0xA8, GUID = 0xB7E4C05058F97337, NameHash = 0x28AB5E6C29FCA8E5)]
    public class GcRealityIcon : NMSTemplate
    {
        public NMSString0x20A ID;
        public TkTextureResource Texture;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
