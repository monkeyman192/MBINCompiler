namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8044580930E9C64, NameHash = 0x2BE2D93A)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x20 */ public VariableSizeString SpecificOverrideUA;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x20 CommunityOverrideUA;
        [NMS(Index = 6)]
        /* 0x50 */ public bool PartOfAtlasStory;
        [NMS(Index = 5)]
        /* 0x51 */ public bool WarpToRendezvousForThisStage;
        [NMS(Index = 2)]
        /* 0x52 */ public bool WarpToSpace;
    }
}
