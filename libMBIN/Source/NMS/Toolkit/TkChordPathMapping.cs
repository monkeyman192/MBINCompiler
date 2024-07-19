using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF17773FA04F148B5, NameHash = 0x124F4F63)]
    public class TkChordPathMapping : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 0)]
        /* 0x20 */ public List<TkInputEnum> ButtonIds;
        [NMS(Index = 4)]
        /* 0x30 */ public VariableSizeString OverlayIcon;
        [NMS(Index = 3)]
        /* 0x40 */ public VariableSizeString SolidIcon;
        [NMS(Index = 5)]
        /* 0x50 */ public VariableSizeString SpecialIcon;
        [NMS(Index = 2)]
        /* 0x60 */ public NMSString0x10 TextTag;
    }
}
