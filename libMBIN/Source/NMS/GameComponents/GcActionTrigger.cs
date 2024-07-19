using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14D9E077D31E7E09, NameHash = 0x8EB09A83)]
    public class GcActionTrigger : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSTemplate> Action;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSTemplate Event;
    }
}
