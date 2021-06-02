using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0xC00, GUID = 0x033D9E9B61DD55AF, NameHash = 0x40643395614391FA)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 LastLoadedModel;
        /* 0x100 */ public NMSString0x100 LastActiveLayout;
        [NMS(Size = 0xA)]
        /* 0x200 */ public NMSString0x100[] FileBrowserRecents;
    }
}
