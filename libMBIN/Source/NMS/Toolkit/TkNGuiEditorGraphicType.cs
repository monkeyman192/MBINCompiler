using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x17C1C8DC8893E779, NameHash = 0x2DD2249029019040)]
    public class TkNGuiEditorGraphicType : NMSTemplate
    {
        // size: 0x48
        public enum NGuiEditorGraphicEnum {
            Panel, Button, Text, Graphic, WindowTitleBar, WindowTitleBarInactive, WindowTab, WindowTabInactive, Window, WindowPane,
            WindowResize, WindowClose, WindowMinimize, WindowMaximize, ScrollBarBackground, ScrollBarForeground, TreeNodeCollapsed, TreeNodeExpanded, CheckBoxTrue, CheckBoxFalse,
            TextInput, Increment, Decrement, Cursor, TextSelection, Separator, EditorResize, EditorMove, EditorOverlay, FileBrowser,
            ColourEdit, IconButton, SliderKnob, SliderBar, IconButtonText, TextInputLabel, Category, Taskbar, TaskbarItem, StartBarWindow,
            ComboBox, ComboBoxWindow, IconListItem, IconListItemSelected, ImageButton, Toolbar, ToolbarGraphic, ToolbarOptions, Rectangle, TreeNodeBorder,
            Background, GroupTitle, TextLabelSeparator, AlignmentAnchor, MinimiseHighlight, Table, TableBorder, TableFolderButton, TableAddEntryButton, TreeNode,
            CategoryCollapsed, CategoryExpanded, WindowTitleBarDragTarget, IconButtonSelected, Line, TreeNodeBackground, TreeNodeCategoryBackground, SceneNodeBackground, PinChildren, UnpinChildren,
            DynamicPanel, DynamicPanelTitle
        }
        public NGuiEditorGraphicEnum NGuiEditorGraphic;
    }
}
