using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x54EDD9E4B9754411, NameHash = 0xBC97B5A50FBB25EA)]
    public class TkButtonPathMapping : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x20A Name;
        [NMS(Index = 5)]
        /* 0x020 */ public TkInputHandEnum Hand;
        [NMS(Index = 0)]
        /* 0x024 */ public TkInputEnum Id;
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
