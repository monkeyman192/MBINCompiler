using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB34D3EA398696052, NameHash = 0x1B8AE85)]
    public class TkNGuiEditorLayout : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkNGuiEditorSavedFavourite> FavouriteData;
        [NMS(Index = 4)]
        /* 0x10 */ public List<int> FavouriteTreeNodeChildCounts;
        [NMS(Index = 3)]
        /* 0x20 */ public List<NMSString0x100> FavouriteTreeNodes;
        [NMS(Index = 2)]
        /* 0x30 */ public List<TkNGuiEditorSavedTreeNodeModification> TreeNodeModificationData;
        [NMS(Index = 0, Size = 0x100)]
        /* 0x40 */ public TkNGuiWindowLayoutData[] Windows;
    }
}
