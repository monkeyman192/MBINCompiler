using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x968D796CF16400E, NameHash = 0xECF89DFCB0AF1DBF)]
    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Reference;
        [NMS(Size = 0x80)]
        public string LSystem;
    }
}
