using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66D42310D501E21, NameHash = 0x7355BB5E5AC6EB4A)]
    public class GcInteractionBuffer : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcInteractionData> Interactions;
        [NMS(Index = 1)]
        /* 0x10 */ public int CurrentPos;
    }
}
