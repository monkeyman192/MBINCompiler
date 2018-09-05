namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x5330)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Font;

        [NMS(Size = 0xA)]
        public GcNGuiPresetGraphic[] Layer;

        [NMS(Size = 0xA)]
        public GcNGuiPresetGraphic[] Graphic;

        [NMS(Size = 0xA)]
        public GcNGuiPresetText[] Text;

        public GcNGuiLayoutData SpacingLayout;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding5300;
    }
}
