using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD761BC189BC4D594, NameHash = 0x1EF39842)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Index = 3, Size = 0xA)]
        /* 0x0000 */ public GcNGuiPresetText[] Text;
        [NMS(Index = 2, Size = 0xA)]
        /* 0x1A40 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Index = 1, Size = 0xA)]
        /* 0x2D50 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Index = 4, MxmlName = "Spacing Layout")]
        /* 0x4060 */ public GcNGuiLayoutData SpacingLayout;
        [NMS(Index = 0)]
        /* 0x40A8 */ public GcFilename Font;
    }
}
