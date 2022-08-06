using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF9B2EE21C846E8CC, NameHash = 0x408CCAADC93DEEFE)]
    public class GcPlanetSectionData : NMSTemplate
    {
        /* 0x0 */ public ulong DiscovererUID;
        /* 0x8 */ public ushort DiscovererPlatform;  // I think this is maybe an enum with base type ushort... In the save file this is 
        /* 0xA */ public bool DiscoveredState;
    }
}
