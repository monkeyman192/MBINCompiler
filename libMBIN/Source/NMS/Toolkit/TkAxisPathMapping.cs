using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x31277648D39D0995, NameHash = 0xC90ECF36)]
    public class TkAxisPathMapping : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 3)]
        /* 0x20 */ public VariableSizeString OverlayIcon;
        [NMS(Index = 2)]
        /* 0x30 */ public VariableSizeString SolidIcon;
        [NMS(Index = 4)]
        /* 0x40 */ public VariableSizeString SpecialIcon;
        [NMS(Index = 5)]
        /* 0x50 */ public TkInputHandEnum Hand;
        [NMS(Index = 0)]
        /* 0x54 */ public TkInputAxisEnum Id;
        [NMS(Index = 6)]
        /* 0x58 */ public NMSString0x20 OpenVROriginNames;
    }
}
