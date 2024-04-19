using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5733CBA8C6D4D8, NameHash = 0x31B2A19D40422178)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x0000 */ public GcNGuiPresetText[] Text;
        [NMS(Size = 0xA)]
        /* 0x26C0 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Size = 0xA)]
        /* 0x4240 */ public GcNGuiPresetGraphic[] Layer;
        /* 0x5DC0 */ public GcNGuiLayoutData SpacingLayout;
        /* 0x5E08 */ public NMSString0x80 Font;
    }
}
