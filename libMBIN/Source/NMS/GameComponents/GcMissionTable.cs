using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FCBAE2FF1F4106F, NameHash = 0x26335C55292A7766)]
    public class GcMissionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericMissionSequence> Missions;
    }
}
