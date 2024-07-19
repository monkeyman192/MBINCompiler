using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x271094F6DC40FFF3, NameHash = 0x99B95D0F)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTriggerFeedbackState> Events;
    }
}
