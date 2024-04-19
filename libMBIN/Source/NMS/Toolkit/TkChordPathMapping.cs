using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x623038C9F447B3B2, NameHash = 0xA012CD9DA9418E41)]
    public class TkChordPathMapping : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public List<TkInputEnum> ButtonIds;
        /* 0x030 */ public NMSString0x10 TextTag;
        /* 0x040 */ public NMSString0x80 OverlayIcon;
        /* 0x0C0 */ public NMSString0x80 SolidIcon;
        /* 0x140 */ public NMSString0x80 SpecialIcon;
    }
}
