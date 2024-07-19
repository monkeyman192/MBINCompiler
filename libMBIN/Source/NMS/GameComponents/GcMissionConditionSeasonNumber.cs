using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB03780BB009D3F26, NameHash = 0xF7974213)]
    public class GcMissionConditionSeasonNumber : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<int> IncludeOtherSeasons;
        [NMS(Index = 0)]
        /* 0x10 */ public int ActiveSeason;
        [NMS(Index = 1)]
        /* 0x14 */ public bool IncludeRemix;
    }
}
