namespace libMBIN.Models.Structs
{
    public class GcTileTypeSet : NMSTemplate
    {
        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
