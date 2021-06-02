using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x410, GUID = 0x1F89606C24B5570D, NameHash = 0x633D54FB94B2C6A4)]
    public class GcNGuiPresetText : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x050 */ public TkNGuiTextStyle Style;
        /* 0x170 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x390 */ public NMSString0x80 Image;
    }
}
