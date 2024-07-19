using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BD58543A9BCA970, NameHash = 0xF29047E5)]
    public class GcTechList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> AvailableTech;
    }
}
