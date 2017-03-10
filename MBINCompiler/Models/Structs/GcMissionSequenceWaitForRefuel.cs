namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForRefuel : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
        /* 0x100 */ public GcStatsTypes TargetStat;
        /* 0x104 */ public int Amount;
    }
}
