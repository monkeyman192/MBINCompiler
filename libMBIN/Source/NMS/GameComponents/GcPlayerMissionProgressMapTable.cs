using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BBEE407C4603433, NameHash = 0x5A66ABB94CAE9E65)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}
