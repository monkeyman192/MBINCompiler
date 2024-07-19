using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4842FEA0C873F825, NameHash = 0x3989DE20)]
    public class GcExpeditionEventTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcExpeditionEventData> Events;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcExpeditionInterventionEventData> InterventionEvents;
    }
}
