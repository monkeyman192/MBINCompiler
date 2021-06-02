using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA0, GUID = 0xAAC94F73173CF13F, NameHash = 0x89F774448E48DD4A)]
    public class TkLSystemRuleTemplate : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x80 LSystem;
    }
}