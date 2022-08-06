using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x97711ED5616C8AA0, NameHash = 0x5A66ABB94CAE9E65)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}