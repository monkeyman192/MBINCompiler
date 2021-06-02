using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x3A71A602C3D9F99C, NameHash = 0x471C446618668C68)]
    public class GcBasePartSearchFilter : NMSTemplate
    {
        public NMSString0x10 IsSpecificID;
        public bool PartIsOnline;
        public bool PartIsNotOnline;
        public bool ApplyGridFilter;
        [NMS(Size = 0x1, Ignore = true)]
        public byte[] Padding13;
        public GcBaseGridSearchFilter BaseGridFilter;
    }
}
