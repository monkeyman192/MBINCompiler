using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x90, GUID = 0xB311727CC90EC0B2, NameHash = 0x1FC4AFB61328FD1E)]
    public class TkControllerButtonLookup : NMSTemplate
    {
        public NMSString0x10 Id;
        public NMSString0x80 ButtonImageLookupFilename;
    }
}