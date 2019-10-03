using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCE8016C66EC09E79, NameHash = 0x1683B0270AE180)]
    public class GcNGuiFileBrowserRecents : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public NMSString0x100[] Recents;
    }
}
