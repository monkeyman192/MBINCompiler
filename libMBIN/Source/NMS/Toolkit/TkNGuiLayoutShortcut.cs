using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6522DBD64B3343B0, NameHash = 0xC79B8646)]
    public class TkNGuiLayoutShortcut : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkNGuiEditorIcons EditorIcon;
        [NMS(Index = 0)]
        /* 0x04 */ public NMSString0x20 Name;
        [NMS(Index = 2)]
        /* 0x24 */ public bool Available;
    }
}
