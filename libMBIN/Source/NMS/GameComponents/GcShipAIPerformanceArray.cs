using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB2C35167751204F, NameHash = 0x5DC80D176A978C38)]
    public class GcShipAIPerformanceArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSTemplate> Array;
    }
}
