using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D0FED1AE002FF9A, NameHash = 0x5547CD97D9D4DE4)]
    public class GcNPCInteractionsDataTable : NMSTemplate
    {
        public List<GcNPCInteractionData> NPCInteractions;
    }
}
