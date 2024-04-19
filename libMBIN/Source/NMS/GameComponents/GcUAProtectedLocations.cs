using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0E3C76254330565, NameHash = 0xD522308022E072F4)]
    public class GcUAProtectedLocations : NMSTemplate
    {
        /* 0x00 */ public List<GcProtectedLocation> ProtectedLocations;
        /* 0x10 */ public ulong UA;
    }
}
