using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB986EE80E8DFBC5, NameHash = 0x6B836C254C32C0FC)]
    public class GcScanDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcScanDataTableEntry> ScanData;
    }
}
