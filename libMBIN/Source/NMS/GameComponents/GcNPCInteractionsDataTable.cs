using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9863F20AC1A23EC7, NameHash = 0x5547CD97D9D4DE4)]
    public class GcNPCInteractionsDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCInteractionData> NPCInteractions;
    }
}
