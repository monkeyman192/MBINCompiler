using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24, GUID = 0xDF284C3967A7FFBC, NameHash = 0x2C7E1C9121ED92E2)]
    public class GcNumberedTextList : NMSTemplate
    {
        public NMSString0x20 Format;
        public int Count;
    }
}
