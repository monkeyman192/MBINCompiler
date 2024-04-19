using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x954A7CAAD6ABB15A, NameHash = 0x828E03CA6A18781E)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ScanOverrideData;
        /* 0x010 */ public float WaitTime;
        /* 0x014 */ public NMSString0x80 DebugText;
        /* 0x094 */ public NMSString0x80 Message;
        [NMS(Size = 0xB, EnumType = typeof(GcScanType.ScanTypeEnum))]
        /* 0x114 */ public bool[] ScanTypesToOverride;
        /* 0x11F */ public bool BlockTimedScans;
        /* 0x120 */ public bool RequiresMissionActive;
    }
}
