namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x887BBA88070AB01D, NameHash = 0x307BF86B)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        [NMS(Index = 6, Size = 0xA)]
        /* 0x0000 */ public NMSString0x10[] AnimationViewerRecents;
        [NMS(Index = 7, Size = 0xA)]
        /* 0x00A0 */ public NMSString0x10[] AnimationViewerRecentWindows;
        [NMS(Index = 9)]
        /* 0x0140 */ public float NguiScale;
        [NMS(Index = 3, Size = 0x14)]
        /* 0x0144 */ public NMSString0x80[] FavouriteWindows;
        [NMS(Index = 5, Size = 0xA)]
        /* 0x0B44 */ public NMSString0x100[] FileBrowserFavourites;
        [NMS(Index = 4, Size = 0xA)]
        /* 0x1544 */ public NMSString0x100[] FileBrowserRecents;
        [NMS(Index = 1)]
        /* 0x1F44 */ public NMSString0x100 LastActiveLayout;
        [NMS(Index = 0)]
        /* 0x2044 */ public NMSString0x100 LastLoadedModel;
        [NMS(Index = 8)]
        /* 0x2144 */ public bool CanSelectRegionDecoratorNodesInDebugEditor;
        [NMS(Index = 2)]
        /* 0x2145 */ public bool FileBrowserAutoBuildTree;
    }
}
