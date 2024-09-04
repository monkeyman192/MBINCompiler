using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6092D780CAFBBAC, NameHash = 0xBEA4D836)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProceduralTechnologyData> Table;
    }
}
