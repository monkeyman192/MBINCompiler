using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3E0F18A974B10EA, NameHash = 0x56F9C280B6CFD741)]
    public class GcMissionConditionSeasonNumber : NMSTemplate
    {
        /* 0x00 */ public List<int> IncludeOtherSeasons;
        /* 0x10 */ public int ActiveSeason;
        /* 0x14 */ public bool IncludeRemix;
    }
}
