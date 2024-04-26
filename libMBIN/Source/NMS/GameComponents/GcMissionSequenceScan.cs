using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x954A7CAAD6ABB15A, NameHash = 0x828E03CA6A18781E)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x10 ScanOverrideData;
        [NMS(Index = 1)]
        /* 0x010 */ public float WaitTime;
        [NMS(Index = 6)]
        /* 0x014 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x094 */ public NMSString0x80 Message;
        [NMS(Index = 3, Size = 0xB, EnumType = typeof(GcScanType.ScanTypeEnum))]
        /* 0x114 */ public bool[] ScanTypesToOverride;
        [NMS(Index = 2)]
        /* 0x11F */ public bool BlockTimedScans;
        [NMS(Index = 5)]
        /* 0x120 */ public bool RequiresMissionActive;
    }
}
