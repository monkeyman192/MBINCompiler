namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x15C71D80B19E4AE8, NameHash = 0xB649393FB6E397AE)]
    public class TKNGuiEditorComponentSize : NMSTemplate
    {
        // size: 0x30
        public enum NGuiEditorComponentSizeEnum : uint {
            WindowResize,
            WindowButton,
            Indent,
            SeparatorHeight,
            SeparatorWidth,
            TreeNodeExpander,
            CheckBox,
            Adjuster,
            Cursor,
            TextEditSeparator,
            DefaultLineHeight,
            ColourEditHeight,
            ColourEditWidth,
            FileBrowser,
            EditorResize,
            EditorMove,
            IconButton,
            SliderKnob,
            SliderBarWidth,
            SliderBarHeight,
            CategoryHeight,
            WindowTitle,
            ScrollSpeed,
            ComboBox,
            Taskbar,
            IconListItem,
            Toolbar,
            ToolbarOptions,
            StartBarWidth,
            StartBarHeight,
            StartBarSearchWidth,
            TreeNodeSpacing,
            VectorSpacing,
            SliderMinSpacing,
            VectorMinSpacing,
            ColourAlphaMinsize,
            SpacingGap,
            Scroll,
            TextLabelSeparator,
            AlignmentAnchor,
            MinimiseHighlightHeight,
            TableButtonSpacing,
            TableHeaderHeight,
            TreeNodeHeight,
            ScrollMargin,
            ScrollIncrement,
            EditorPin,
            DynamicPanelTitle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NGuiEditorComponentSizeEnum NGuiEditorComponentSize;
    }
}
