using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x84, GUID = 0x83447CE313934E8F, NameHash = 0xBE5E5CB33D0EB022)]
    public class TkModelResource : NMSTemplate
    {
        public NMSString0x80 Filename;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
