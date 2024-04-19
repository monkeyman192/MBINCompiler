using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD274DEB39D9026A1, NameHash = 0xF10587272870E7F4)]
    public class GcNGuiElementData : NMSTemplate
    {
        /* 0x00 */ public GcNGuiLayoutData Layout;
        /* 0x48 */ public NMSString0x10 ID;
        /* 0x58 */ public NMSString0x10 PresetID;
        /* 0x68 */ public TkNGuiForcedStyle ForcedStyle;
        /* 0x6C */ public bool IsHidden;
    }
}
