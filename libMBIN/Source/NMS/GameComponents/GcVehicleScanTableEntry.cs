using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x55B5227EBE909829, NameHash = 0xBAC942D350F478B1)]
    public class GcVehicleScanTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 0)]
        /* 0x30 */ public List<NMSString0x20A> ScanList;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTextureResource Icon;
    }
}
