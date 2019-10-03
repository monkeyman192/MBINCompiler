using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x6240, GUID = 0x77169ACD221F6F2C, NameHash = 0x31B2A19D40422178)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public string Font;
        [NMS(Size = 0xA)]
        /* 0x0080 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Size = 0xA)]
        /* 0x1D40 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Size = 0xA)]
        /* 0x3A00 */ public GcNGuiPresetText[] Text;
        /* 0x6200 */ public GcNGuiLayoutData SpacingLayout;
    }
}
