using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1BAA253C1CC2F42, NameHash = 0x5CBD20D1)]
    public class GcVehicleScanTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 3)]
        /* 0x20 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x38 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 0)]
        /* 0x48 */ public List<NMSString0x20A> ScanList;
    }
}
