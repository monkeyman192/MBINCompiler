using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA29C919B6B7990BF, NameHash = 0xBEA4D836)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProceduralTechnologyData> Table;
    }
}
