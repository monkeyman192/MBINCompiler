using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x121EA7B8B458728B, NameHash = 0xA83B1CD89A122A08)]
    public class GcNPCReactionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCReactionEntry> Reactions;
    }
}
