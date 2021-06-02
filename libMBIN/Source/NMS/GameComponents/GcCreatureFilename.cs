using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0x941C900F4BF1D0B, NameHash = 0x964386EAF98E113C)]
    public class GcCreatureFilename : NMSTemplate
    {
        public NMSString0x10 ID;
        public NMSString0x80 Filename;
        public NMSString0x80 ExtraFilename;
    }
}
