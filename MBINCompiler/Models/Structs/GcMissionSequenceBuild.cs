namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceBuild : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
        [NMS(Size = 0x10)]
        /* 0x100 */ public string Part;
        /* 0x110 */ public bool BaseOnly;
        /* 0x114 */ public GcPersistentBaseTypes Base;
    }
}
