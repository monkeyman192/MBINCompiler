using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC56801BADAFB060, NameHash = 0x6B836C254C32C0FC)]
    public class GcScanDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcScanDataTableEntry> ScanData;
    }
}
