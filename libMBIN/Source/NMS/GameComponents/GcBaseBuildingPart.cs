using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6989E342734E2FE2, NameHash = 0xB219FB318ABC12CF)]
    public class GcBaseBuildingPart : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcBaseBuildingPartStyleModel> StyleModels;
    }
}
