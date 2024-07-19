using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E3AE0BB3BC7FB7A, NameHash = 0xF50272A)]
    public class GcScanDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcScanDataTableEntry> ScanData;
    }
}
