namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6578B7A967F7DF, NameHash = 0x416E9E84AB204114)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x100 */ public NMSString0x20 OverrideUA;
        [NMS(Index = 4)]
        /* 0x120 */ public bool PartOfAtlasStory;
        [NMS(Index = 2)]
        /* 0x121 */ public bool WarpToSpace;
    }
}
