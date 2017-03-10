namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
    }
}
