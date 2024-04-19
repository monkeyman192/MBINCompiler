using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C61BE7015E84E93, NameHash = 0x633D54FB94B2C6A4)]
    public class GcNGuiPresetText : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x1E0 */ public TkNGuiTextStyle Style;
        /* 0x300 */ public GcNGuiLayoutData Layout;
        /* 0x348 */ public NMSString0x10 PresetID;
        /* 0x358 */ public NMSString0x80 Image;
    }
}
