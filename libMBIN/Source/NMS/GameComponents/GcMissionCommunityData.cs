using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2077A7CECC1F140F, Size = 0x20, NameHash = 0xDAB99EB4164B2DF1)]
    public class GcMissionCommunityData : NMSTemplate
    {
        public List<NMSString0x10> CommunityMissionsIDs;
        public List<GcMissionCommunityMissionData> CommunityMissionsData;
    }
}
