using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x7C37DF476B1CF236, NameHash = 0xBC849663458378CD)]
    public class GcExactResource : NMSTemplate
    {
        public NMSString0x80 Filename;
        public GcSeed GenerationSeed;
    }
}