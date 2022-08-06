using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x694C9DF94CECC153, NameHash = 0xD522308022E072F4)]
    public class GcUAProtectedLocations : NMSTemplate
    {
        /* 0x00 */ public ulong UA;
        /* 0x08 */ public List<GcProtectedLocation> ProtectedLocations;
    }
}
