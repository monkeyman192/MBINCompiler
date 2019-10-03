using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1D0, GUID = 0x1859A6B6B214412D, NameHash = 0x19C4AA7DA3B42958)]
    public class TkAxisPathMapping : NMSTemplate
    {
        /* 0x000 */ public TkInputAxisEnum Id;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x008 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x028 */ public string SolidIcon;
        [NMS(Size = 0x80)]
        /* 0x0A8 */ public string OverlayIcon;
        [NMS(Size = 0x80)]
        /* 0x128 */ public string SpecialIcon;
        /* 0x1A8 */ public TkInputHandEnum Hand;
        [NMS(Size = 0x20)]
        /* 0x1AC */ public string OpenVROriginNames;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1CC */ public byte[] EndPadding;
    }
}
