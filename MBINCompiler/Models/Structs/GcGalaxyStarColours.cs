namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Size = 0x4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public Colour[] ColourByStarType;
    }
}
