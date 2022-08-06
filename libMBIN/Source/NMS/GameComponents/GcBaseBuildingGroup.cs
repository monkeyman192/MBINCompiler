using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x51A659AA037EF21B, NameHash = 0xF37F133693523902)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A Name;
        /* 0x30 */ public TkTextureResource Icon;
        /* 0xB4 */ public int DefaultColourIdx;
        /* 0xB8 */ public List<GcBaseBuildingSubGroup> SubGroups;
    }
}
