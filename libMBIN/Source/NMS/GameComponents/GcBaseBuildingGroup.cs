using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFB52E01BB72F6D3, NameHash = 0x84B035E6)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 2)]
        /* 0x20 */ public TkTextureResource Icon;
        [NMS(Index = 0)]
        /* 0x38 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x48 */ public List<GcBaseBuildingSubGroup> SubGroups;
        [NMS(Index = 3)]
        /* 0x58 */ public int DefaultColourIdx;
    }
}
