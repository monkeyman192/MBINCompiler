using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2F60588D843D54E, NameHash = 0xB9B9F46C)]
    public class GcRewardSpecialFromList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A TextFormat;
        [NMS(Index = 1)]
        /* 0x20 */ public List<NMSString0x10> FallbackList;
        [NMS(Index = 0)]
        /* 0x30 */ public List<NMSString0x10> PriorityList;
    }
}
