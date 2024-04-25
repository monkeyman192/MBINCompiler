using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x60587FED618E0B51, NameHash = 0x19C4AA7DA3B42958)]
    public class TkAxisPathMapping : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x20A Name;
        [NMS(Index = 5)]
        /* 0x020 */ public TkInputHandEnum Hand;
        [NMS(Index = 0)]
        /* 0x024 */ public TkInputAxisEnum Id;
        [NMS(Index = 3)]
        /* 0x028 */ public NMSString0x80 OverlayIcon;
        [NMS(Index = 2)]
        /* 0x0A8 */ public NMSString0x80 SolidIcon;
        [NMS(Index = 4)]
        /* 0x128 */ public NMSString0x80 SpecialIcon;
        [NMS(Index = 6)]
        /* 0x1A8 */ public NMSString0x20 OpenVROriginNames;
    }
}
