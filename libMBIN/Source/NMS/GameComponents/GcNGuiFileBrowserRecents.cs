using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiFileBrowserRecents : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public NMSString0x100[] Recents;
    }
}
