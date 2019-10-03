using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1C0, GUID = 0xA3C3DED31839DA1A, NameHash = 0xA012CD9DA9418E41)]
    public class TkChordPathMapping : NMSTemplate
    {
        public List<TkInputEnum> ButtonIds;
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x10)]
        public string TextTag;
        [NMS(Size = 0x80)]
        public string SolidIcon;
        [NMS(Size = 0x80)]
        public string OverlayIcon;
        [NMS(Size = 0x80)]
        public string SpecialIcon;
    }
}
