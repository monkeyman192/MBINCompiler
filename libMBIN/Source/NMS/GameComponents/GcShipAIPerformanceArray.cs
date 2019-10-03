using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5F63DA0FE984966E, NameHash = 0x5DC80D176A978C38)]
    public class GcShipAIPerformanceArray : NMSTemplate
    {
        public List<NMSTemplate> Array;
    }
}
