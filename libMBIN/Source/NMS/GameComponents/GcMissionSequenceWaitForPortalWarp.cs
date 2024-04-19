namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6578B7A967F7DF, NameHash = 0x416E9E84AB204114)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 DebugText;
        /* 0x080 */ public NMSString0x80 Message;
        /* 0x100 */ public NMSString0x20 OverrideUA;
        /* 0x120 */ public bool PartOfAtlasStory;
        /* 0x121 */ public bool WarpToSpace;
    }
}
