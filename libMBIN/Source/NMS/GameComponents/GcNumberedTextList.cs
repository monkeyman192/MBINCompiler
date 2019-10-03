using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDF284C3967A7FFBC, NameHash = 0x2C7E1C9121ED92E2)]
    public class GcNumberedTextList : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Format;
        public int Count;
    }
}
