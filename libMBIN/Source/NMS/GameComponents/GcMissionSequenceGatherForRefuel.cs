using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD12E41EAE72B602F, NameHash = 0x9FA5A1E5E026A5B3)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x04 */ public GcStatsTypes TargetStat;
        [NMS(Index = 3)]
        /* 0x08 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x88 */ public NMSString0x80 Message;
    }
}
