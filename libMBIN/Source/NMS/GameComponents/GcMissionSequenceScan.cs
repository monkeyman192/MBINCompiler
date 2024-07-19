using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x763124E7E544BAC, NameHash = 0x92E61D4C)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 ScanOverrideData;
        [NMS(Index = 1)]
        /* 0x30 */ public float WaitTime;
        [NMS(Index = 3, Size = 0xB, EnumType = typeof(GcScanType.ScanTypeEnum))]
        /* 0x34 */ public bool[] ScanTypesToOverride;
        [NMS(Index = 2)]
        /* 0x3F */ public bool BlockTimedScans;
        [NMS(Index = 5)]
        /* 0x40 */ public bool RequiresMissionActive;
    }
}
