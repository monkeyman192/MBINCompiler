using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6A4AB31A7EF9A2F, NameHash = 0x6B836C254C32C0FC)]
    public class GcScanDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcScanDataTableEntry> ScanData;
    }
}
