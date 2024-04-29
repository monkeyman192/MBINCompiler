using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AEAC0FEA136B4D2, NameHash = 0xEE25A96466342A98)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}
