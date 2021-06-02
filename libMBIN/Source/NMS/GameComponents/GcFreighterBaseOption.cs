using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0xEFADC778D8A5950B, NameHash = 0x27F9FF00242DF25A)]
    public class GcFreighterBaseOption : NMSTemplate
    {
        public NMSString0x80 BaseDataFile;
        public float ProbabilityWeighting;
    }
}
