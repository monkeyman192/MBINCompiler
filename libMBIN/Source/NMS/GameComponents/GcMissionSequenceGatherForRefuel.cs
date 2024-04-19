using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA330E65E57905850, NameHash = 0x9FA5A1E5E026A5B3)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        /* 0x00 */ public int Amount;
        /* 0x04 */ public GcStatsTypes TargetStat;
        /* 0x08 */ public NMSString0x80 DebugText;
        /* 0x88 */ public NMSString0x80 Message;
    }
}
