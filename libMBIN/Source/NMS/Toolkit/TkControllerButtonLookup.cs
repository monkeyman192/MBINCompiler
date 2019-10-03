using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB311727CC90EC0B2, NameHash = 0x1FC4AFB61328FD1E)]
    public class TkControllerButtonLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string ButtonImageLookupFilename;
    }
}
