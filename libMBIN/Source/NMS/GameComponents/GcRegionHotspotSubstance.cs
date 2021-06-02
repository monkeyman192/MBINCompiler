using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x7AAA8A17257BB80C, NameHash = 0x9A26DA40EA0EA5D4)]
    public class GcRegionHotspotSubstance : NMSTemplate
    {
        public NMSString0x10 SubstanceId;
        public int AmountCost;
        public int SubstanceYeild;
    }
}
