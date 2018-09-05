namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x121)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
        /* 0x100 */ public bool WarpToSpace;
        /* 0x101 */ public NMSString0x20 OverrideUA;
    }
}
