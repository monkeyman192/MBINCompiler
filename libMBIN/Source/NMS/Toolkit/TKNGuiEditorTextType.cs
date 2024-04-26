namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCE328FD208CBB692, NameHash = 0x4780AB6325CE84C6)]
    public class TKNGuiEditorTextType : NMSTemplate
    {
        // size: 0xE
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NGuiEditorTextEnum NGuiEditorText;
    }
}
