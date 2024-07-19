using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76AF606618B1FB06, NameHash = 0x9EC89436)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}
