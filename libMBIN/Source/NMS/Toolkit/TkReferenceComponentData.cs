using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x100, GUID = 0x968D796CF16400E, NameHash = 0xECF89DFCB0AF1DBF)]
    public class TkReferenceComponentData : NMSTemplate
    {
        public NMSString0x80 Reference;
        public NMSString0x80 LSystem;
    }
}