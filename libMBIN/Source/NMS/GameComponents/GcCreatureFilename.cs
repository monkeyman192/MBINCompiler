using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0x941C900F4BF1D0B, NameHash = 0x964386EAF98E113C)]
    public class GcCreatureFilename : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 0x80)]
        public string ExtraFilename;
    }
}
