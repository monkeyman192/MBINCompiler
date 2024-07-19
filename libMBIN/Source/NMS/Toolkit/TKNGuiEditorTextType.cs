namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1F67D02041701022, NameHash = 0x9351C747)]
    public class TKNGuiEditorTextType : NMSTemplate
    {
        // size: 0xF
        public enum NGuiEditorTextEnum : uint {
            Text,
            Button,
            WindowTab,
            WindowTabInactive,
            TreeNode,
            CheckBox,
            TextInput,
            TextInputLabel,
            TextInputLabelHeader,
            Category,
            TaskBar,
            GroupTitle,
            TreeNodeSelected,
            DynamicPanelTitle,
            ContextMenuButton,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NGuiEditorTextEnum NGuiEditorText;
    }
}
