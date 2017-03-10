namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyRenderAnostreakData : NMSTemplate
    {
        public Colour OuterColour;
        public Colour InnerColour;
        public float VerticalCompression;
        public float HorizontalScale;
        public float Contrast;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding;
    }
}
