using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xEAC4103F7718C92A, NameHash = 0x19C4AA7DA3B42958)]
    public class TkAxisPathMapping : NMSTemplate
    {
        /* 0x000 */ public TkInputAxisEnum Id;
        /* 0x008 */ public NMSString0x20A Name;
        /* 0x028 */ public NMSString0x80 SolidIcon;
        /* 0x0A8 */ public NMSString0x80 OverlayIcon;
        /* 0x128 */ public NMSString0x80 SpecialIcon;
        /* 0x1A8 */ public TkInputHandEnum Hand;
        /* 0x1AC */ public NMSString0x20 OpenVROriginNames;
    }
}
