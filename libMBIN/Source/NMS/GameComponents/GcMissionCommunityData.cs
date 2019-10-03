using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x44B0D0FD1CD2DD81, Size = 0x20, NameHash = 0xDAB99EB4164B2DF1)]
    public class GcMissionCommunityData : NMSTemplate
    {
        public List<NMSString0x10> CommunityMissionsIDs;
        public List<GcMissionCommunityMissionData> CommunityMissionsData;
    }
}
