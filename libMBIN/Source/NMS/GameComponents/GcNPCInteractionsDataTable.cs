using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE27318D28B6EB858, NameHash = 0xE50541DA)]
    public class GcNPCInteractionsDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCInteractionData> NPCInteractions;
    }
}
