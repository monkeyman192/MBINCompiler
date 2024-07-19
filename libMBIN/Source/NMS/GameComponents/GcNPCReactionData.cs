using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4918D3269B05D3E, NameHash = 0x5589CB5C)]
    public class GcNPCReactionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCReactionEntry> Reactions;
    }
}
