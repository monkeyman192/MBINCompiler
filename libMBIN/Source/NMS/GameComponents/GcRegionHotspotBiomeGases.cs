using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xE905650FB4B4A2B6, NameHash = 0xDEE18E7D4FF23F39)]
    public class GcRegionHotspotBiomeGases : NMSTemplate
    {
        public NMSString0x10 Gas1Id;
        public NMSString0x10 Gas2Id;
    }
}