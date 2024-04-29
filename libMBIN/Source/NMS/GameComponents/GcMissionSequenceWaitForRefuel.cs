using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24DE95B53FB37561, NameHash = 0x25696B35BE341F6C)]
    public class GcMissionSequenceWaitForRefuel : NMSTemplate
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
