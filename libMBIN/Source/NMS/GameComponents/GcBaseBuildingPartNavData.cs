using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA7F26ECC3E9CEAC, NameHash = 0x8065BADE)]
    public class GcBaseBuildingPartNavData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A PartID;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcBaseBuildingPartNavNodeData> NavNodeData;
        [NMS(Index = 1)]
        /* 0x30 */ public List<GcBaseBuildingPartInteractionData> SharedInteractions;
    }
}
