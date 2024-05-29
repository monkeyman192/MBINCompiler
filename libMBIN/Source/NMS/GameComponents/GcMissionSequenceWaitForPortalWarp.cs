namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3106552C33A43583, NameHash = 0x416E9E84AB204114)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public VariableSizeString SpecificOverrideUA;
        [NMS(Index = 1)]
        /* 0x010 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x090 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x110 */ public NMSString0x20 CommunityOverrideUA;
        [NMS(Index = 5)]
        /* 0x130 */ public bool PartOfAtlasStory;
        [NMS(Index = 2)]
        /* 0x131 */ public bool WarpToSpace;
    }
}
