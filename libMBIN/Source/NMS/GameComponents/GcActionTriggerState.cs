using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FF1827A7601B77B, NameHash = 0xF6A08813)]
    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 StateID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcActionTrigger> Triggers;
    }
}
