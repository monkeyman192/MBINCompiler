using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22AD053B541A95AF, NameHash = 0x80ED6EE04AC8D620)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProceduralTechnologyData> Table;
    }
}
