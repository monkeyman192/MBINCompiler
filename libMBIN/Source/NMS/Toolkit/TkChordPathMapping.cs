using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1C0, GUID = 0x277CAE7625F2B25D, NameHash = 0xA012CD9DA9418E41)]
    public class TkChordPathMapping : NMSTemplate
    {
        public List<TkInputEnum> ButtonIds;
        public NMSString0x20 Name;
        public NMSString0x10 TextTag;
        public NMSString0x80 SolidIcon;
        public NMSString0x80 OverlayIcon;
        public NMSString0x80 SpecialIcon;
    }
}
