using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA655B29E93581B1, NameHash = 0xDA4CC10DF6E92F8C)]
    public class GcStoryPage : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource Icon;
        /* 0x88 */ public NMSString0x20A ID;
        /* 0xA8 */ public List<NMSString0x20A> Entries;
    }
}
