using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x3FD4C8C19F49F1A4, NameHash = 0x471C446618668C68)]
    public class GcBasePartSearchFilter : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string IsSpecificID;
        public bool PartIsOnline;
        public bool PartIsNotOnline;
        public bool ApplyGridFilter;
        [NMS(Size = 0x1, Ignore = true)]
        public byte[] Padding13;
        public GcBaseGridSearchFilter BaseGridFilter;
    }
}
