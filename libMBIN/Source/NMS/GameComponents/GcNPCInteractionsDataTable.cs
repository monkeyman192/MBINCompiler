using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1699273FB2B21EB, NameHash = 0x5547CD97D9D4DE4)]
    public class GcNPCInteractionsDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCInteractionData> NPCInteractions;
    }
}
