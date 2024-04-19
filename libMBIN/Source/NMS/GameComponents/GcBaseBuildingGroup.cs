using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3441CC565EC3BCC0, NameHash = 0xF37F133693523902)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Name;
        /* 0x20 */ public NMSString0x10 ID;
        /* 0x30 */ public List<GcBaseBuildingSubGroup> SubGroups;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public int DefaultColourIdx;
    }
}
