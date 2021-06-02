using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1D0, GUID = 0xC5D79446117184CF, NameHash = 0xBC97B5A50FBB25EA)]
    public class TkButtonPathMapping : NMSTemplate
    {
        /* 0x000 */ public TkInputEnum Id;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        /* 0x008 */ public NMSString0x20 Name;
        /* 0x028 */ public NMSString0x80 SolidIcon;
        /* 0x0A8 */ public NMSString0x80 OverlayIcon;
        /* 0x128 */ public NMSString0x80 SpecialIcon;
        /* 0x1A8 */ public TkInputHandEnum Hand;
        /* 0x1AC */ public NMSString0x20 OpenVROriginNames;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1CC */ public byte[] EndPadding;
    }
}
