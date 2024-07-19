using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4651D16F90E916F, NameHash = 0xDAD16E07)]
    public class GcConstructionPartGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcConstructionPart> ValidParts;
    }
}
