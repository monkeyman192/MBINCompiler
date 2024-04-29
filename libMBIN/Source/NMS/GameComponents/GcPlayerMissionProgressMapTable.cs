using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA8B8CB293F0ED3F, NameHash = 0x5A66ABB94CAE9E65)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}
