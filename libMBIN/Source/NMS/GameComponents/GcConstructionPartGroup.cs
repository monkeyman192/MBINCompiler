using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20D535EBE39C9B90, NameHash = 0x5C13C1ADB7C38C49)]
    public class GcConstructionPartGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcConstructionPart> ValidParts;
    }
}
