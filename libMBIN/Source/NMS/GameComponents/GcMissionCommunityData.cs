using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x172934B163792321, NameHash = 0xD6A23EB9)]
    public class GcMissionCommunityData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMissionCommunityMissionData> CommunityMissionsData;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> CommunityMissionsIDs;
    }
}
