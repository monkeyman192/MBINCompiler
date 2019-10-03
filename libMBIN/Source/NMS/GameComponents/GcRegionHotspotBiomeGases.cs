using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE905650FB4B4A2B6, NameHash = 0xDEE18E7D4FF23F39)]
    public class GcRegionHotspotBiomeGases : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Gas1Id;
        [NMS(Size = 0x10)]
        public string Gas2Id;
    }
}
