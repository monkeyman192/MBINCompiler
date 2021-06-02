using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x6420, GUID = 0x8C639FE8E6E9A6C3, NameHash = 0x31B2A19D40422178)]
    public class GcNGuiPreset : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Font;
        [NMS(Size = 0xA)]
        /* 0x0080 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Size = 0xA)]
        /* 0x1DE0 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Size = 0xA)]
        /* 0x3B40 */ public GcNGuiPresetText[] Text;
        /* 0x63E0 */ public GcNGuiLayoutData SpacingLayout;
    }
}
