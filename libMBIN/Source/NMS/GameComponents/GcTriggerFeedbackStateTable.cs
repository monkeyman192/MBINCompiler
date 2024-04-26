using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EEDF377F0834C8F, NameHash = 0x6E458F753254E426)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTriggerFeedbackState> Events;
    }
}
