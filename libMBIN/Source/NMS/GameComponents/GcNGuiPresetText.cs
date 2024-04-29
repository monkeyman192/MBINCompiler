using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C32ABBE99FF4FD8, NameHash = 0x633D54FB94B2C6A4)]
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 2)]
        /* 0x1E0 */ public TkNGuiTextStyle Style;
        [NMS(Index = 1)]
        /* 0x300 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 0)]
        /* 0x348 */ public NMSString0x10 PresetID;
        [NMS(Index = 4)]
        /* 0x358 */ public NMSString0x80 Image;
    }
}
