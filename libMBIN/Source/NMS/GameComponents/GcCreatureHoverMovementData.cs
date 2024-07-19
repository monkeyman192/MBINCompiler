using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2148C4F59649D476, NameHash = 0x6AE734CB)]
    public class GcCreatureHoverMovementData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureHoverMovementDataParams> Params;
    }
}
