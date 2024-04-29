using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C62850407418770, NameHash = 0x6E458F753254E426)]
    public class GcTriggerFeedbackStateTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTriggerFeedbackState> Events;
    }
}
