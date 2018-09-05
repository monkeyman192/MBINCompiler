using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcExpeditionEventTable : NMSTemplate
    {
        public List<GcExpeditionEventData> Events;
        public List<GcExpeditionInterventionEventData> InterventionEvents;
    }
}
