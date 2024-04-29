using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1056FD670E268D85, NameHash = 0xDA977EF5139B54E5)]
    public class GcPlayerMissionUpgradeMapTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerMissionUpgradeMapEntry> MissionProgressTable;
    }
}
