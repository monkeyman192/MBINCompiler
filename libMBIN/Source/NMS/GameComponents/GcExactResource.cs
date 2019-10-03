using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7C37DF476B1CF236, NameHash = 0xBC849663458378CD)]
    public class GcExactResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        public GcSeed GenerationSeed;
    }
}
