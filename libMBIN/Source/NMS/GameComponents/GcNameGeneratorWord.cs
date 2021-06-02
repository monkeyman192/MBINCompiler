using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xB53BA0DB9BED6F2B, NameHash = 0x814E1DAF35C8BB77)]
    public class GcNameGeneratorWord : NMSTemplate
    {
        public NMSString0x20A Word;
        public int NumOptions;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
