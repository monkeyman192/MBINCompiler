using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE565A6EF54CE97A, NameHash = 0x99B95D0F)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTriggerFeedbackState> Events;
    }
}
