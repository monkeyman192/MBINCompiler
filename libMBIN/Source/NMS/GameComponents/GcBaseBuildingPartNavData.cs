using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF889885B27980DD0, NameHash = 0xE1F61A258ED99443)]
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
