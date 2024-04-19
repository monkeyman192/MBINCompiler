using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD46AE55D0D3AF365, NameHash = 0x98F063E1CF689716)]
    public class GcSeasonalLogOverrides : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A MissionDescription;
        /* 0x20 */ public NMSString0x20A MissionSubtitle;
        /* 0x40 */ public NMSString0x20A MissionTitle;
        /* 0x60 */ public List<int> ApplicableSeasonNumbers;
    }
}
