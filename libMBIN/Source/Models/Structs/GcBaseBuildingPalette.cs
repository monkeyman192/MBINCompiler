namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        public Colour PrimaryColour;
        public Colour SecondaryColour;
        [NMS(Size = 0x20)]
        public string Name;
    }
}
