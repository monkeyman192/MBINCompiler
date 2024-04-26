using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5329ACC91E367434, NameHash = 0x269AA19701CADAB8)]
    public class GcActionTrigger : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSTemplate Event;
        [NMS(Index = 1)]
        /* 0x50 */ public List<NMSTemplate> Action;
    }
}
