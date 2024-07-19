using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB2C35167751204F, NameHash = 0xA0DA78BA)]
    public class GcShipAIPerformanceArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSTemplate> Array;
    }
}
