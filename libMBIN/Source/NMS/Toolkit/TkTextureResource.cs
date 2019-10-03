using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x84, GUID = 0x8F308DA13045525E, NameHash = 0x2316F23520D820A9)]
    public class TkTextureResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
