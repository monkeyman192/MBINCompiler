using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2C870776658521D, NameHash = 0xCC36BB347C3B3DC3)]
    public class GcScanDataTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcScanData ScanData;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 ID;
    }
}
