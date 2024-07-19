using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93F36E0AF25FD58A, NameHash = 0x79CA2F69)]
    public class GcNGuiElementData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 ID;
        [NMS(Index = 3)]
        /* 0x58 */ public GcNGuiEditorVisibility EditorVisible;
        [NMS(Index = 4)]
        /* 0x5C */ public TkNGuiForcedStyle ForcedStyle;
        [NMS(Index = 2)]
        /* 0x60 */ public bool IgnoreInput;
        [NMS(Index = 1)]
        /* 0x61 */ public bool IsHidden;
    }
}
