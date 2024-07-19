using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E72743A43FC39A8, NameHash = 0x286C5405)]
    public class GcSeasonalLogOverrides : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A MissionDescription;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A MissionSubtitle;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A MissionTitle;
        [NMS(Index = 0)]
        /* 0x60 */ public List<int> ApplicableSeasonNumbers;
    }
}
