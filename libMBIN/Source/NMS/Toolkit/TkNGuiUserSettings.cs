using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB2D143B8D6BC34B3, NameHash = 0x307BF86B)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        [NMS(Index = 7, Size = 0xA)]
        /* 0x0000 */ public NMSString0x10[] AnimationViewerRecents;
        [NMS(Index = 8, Size = 0xA)]
        /* 0x00A0 */ public NMSString0x10[] AnimationViewerRecentWindows;
        [NMS(Index = 12)]
        /* 0x0140 */ public TkNGuiVisualLoggerSettings VisualLogger;
        [NMS(Index = 6)]
        /* 0x0198 */ public float FileBrowserThumbnailSize;
        [NMS(Index = 13)]
        /* 0x019C */ public float NguiScale;
        [NMS(Index = 3, Size = 0x14)]
        /* 0x01A0 */ public NMSString0x80[] FavouriteWindows;
        [NMS(Index = 5, Size = 0xA)]
        /* 0x0BA0 */ public NMSString0x100[] FileBrowserFavourites;
        [NMS(Index = 4, Size = 0xA)]
        /* 0x15A0 */ public NMSString0x100[] FileBrowserRecents;
        [NMS(Index = 1)]
        /* 0x1FA0 */ public NMSString0x100 LastActiveLayout;
        [NMS(Index = 0)]
        /* 0x20A0 */ public NMSString0x100 LastLoadedModel;
        [NMS(Index = 9)]
        /* 0x21A0 */ public bool CanSelectRegionDecoratorNodesInDebugEditor;
        [NMS(Index = 10)]
        /* 0x21A1 */ public bool CanSelectTerrainMeshNodesInDebugEditor;
        [NMS(Index = 11)]
        /* 0x21A2 */ public bool DebugEditorDebugDrawInPlayMode;
        [NMS(Index = 2)]
        /* 0x21A3 */ public bool FileBrowserAutoBuildTree;
    }
}
