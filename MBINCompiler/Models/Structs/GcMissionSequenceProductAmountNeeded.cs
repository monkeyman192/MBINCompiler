namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x100 */ public string Item;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string ToBuild;
        /* 0x120 */ public bool IsRepair;
    }
}
