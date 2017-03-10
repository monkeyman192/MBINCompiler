namespace MBINCompiler.Models.Structs
{
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PresetID;
        public GcNGuiLayoutData Layout;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding3C;

        public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        public string Image;
    }
}
