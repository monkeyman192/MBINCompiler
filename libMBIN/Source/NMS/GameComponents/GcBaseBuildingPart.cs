using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F784CEB72CB7430, NameHash = 0x6B36906D)]
    public class GcBaseBuildingPart : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcBaseBuildingPartStyleModel> StyleModels;
    }
}
