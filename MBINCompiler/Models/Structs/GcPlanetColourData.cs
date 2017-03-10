namespace MBINCompiler.Models.Structs
{
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x29)]
        public GcColourPaletteData[] Palettes;
    }
}
