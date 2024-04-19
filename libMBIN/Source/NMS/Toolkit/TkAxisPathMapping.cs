using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x60587FED618E0B51, NameHash = 0x19C4AA7DA3B42958)]
    public class TkAxisPathMapping : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public TkInputHandEnum Hand;
        /* 0x024 */ public TkInputAxisEnum Id;
        /* 0x028 */ public NMSString0x80 OverlayIcon;
        /* 0x0A8 */ public NMSString0x80 SolidIcon;
        /* 0x128 */ public NMSString0x80 SpecialIcon;
        /* 0x1A8 */ public NMSString0x20 OpenVROriginNames;
    }
}
