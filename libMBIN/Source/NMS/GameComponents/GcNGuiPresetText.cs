using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x400, GUID = 0x5B0FB5749D9C65F1, NameHash = 0x633D54FB94B2C6A4)]
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x050 */ public TkNGuiTextStyle Style;
        /* 0x170 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Size = 0x80)]
        /* 0x380 */ public string Image;
    }
}
