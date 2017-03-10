namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        /* 0x080 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string Message;
    }
}
