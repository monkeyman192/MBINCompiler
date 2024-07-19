using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D8EED3CB033DAC7, NameHash = 0x8069EA15)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}
