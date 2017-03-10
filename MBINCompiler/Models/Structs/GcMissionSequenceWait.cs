namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWait : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        /* 0x080 */ public float Time;
    }
}
