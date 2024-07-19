using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x781BDBA6D5335B6A, NameHash = 0xE060CC72)]
    public class GcStatGroupData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 GroupName;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> TrackedStats;
    }
}
