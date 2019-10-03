using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x703C4FBFD011682A, NameHash = 0x1B2443FC607CC2A)]
    public class GcRegionHotspotTypes : NMSTemplate
    {
        // 0x6 entries
        public enum HotspotTypeEnum { Power, Mineral1, mineral2, Mineral3, Gas1, Gas2 }
        public HotspotTypeEnum HotspotType;
    }
}
