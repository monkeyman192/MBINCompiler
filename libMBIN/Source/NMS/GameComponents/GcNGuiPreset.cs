using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E019D8C10EFE2FB, NameHash = 0x1EF39842)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Index = 3, Size = 0xA)]
        /* 0x0000 */ public GcNGuiPresetText[] Text;
        [NMS(Index = 2, Size = 0xA)]
        /* 0x2440 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Index = 1, Size = 0xA)]
        /* 0x3D40 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Index = 4)]
        /* 0x5640 */ public GcNGuiLayoutData SpacingLayout;
        [NMS(Index = 0)]
        /* 0x5688 */ public VariableSizeString Font;
    }
}
