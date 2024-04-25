using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EB63AD338D0CF15, NameHash = 0xC87C94C721C64FAA)]
    public class GcRewardMultiSpecificProducts : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A SetName;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> ProductIds;
        [NMS(Index = 1)]
        /* 0x30 */ public bool UseListPopup;
    }
}
