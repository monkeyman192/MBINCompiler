using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6F4994F3BE8B774, NameHash = 0xBC97B5A50FBB25EA)]
    public class TkButtonPathMapping : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public TkInputHandEnum Hand;
        /* 0x024 */ public TkInputEnum Id;
        /* 0x028 */ public NMSString0x80 OverlayIcon;
        /* 0x0A8 */ public NMSString0x80 SolidIcon;
        /* 0x128 */ public NMSString0x80 SpecialIcon;
        /* 0x1A8 */ public NMSString0x20 OpenVROriginNames;
    }
}
