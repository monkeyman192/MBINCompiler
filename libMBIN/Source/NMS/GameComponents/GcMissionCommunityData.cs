using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x838663243E988393, NameHash = 0xDAB99EB4164B2DF1)]
    public class GcMissionCommunityData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMissionCommunityMissionData> CommunityMissionsData;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> CommunityMissionsIDs;
    }
}
