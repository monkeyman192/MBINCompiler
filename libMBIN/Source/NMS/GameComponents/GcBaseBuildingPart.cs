using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x874E2264CBC0A4F1, NameHash = 0x6B36906D)]
    public class GcBaseBuildingPart : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcBaseBuildingPartStyleModel> StyleModels;
    }
}
