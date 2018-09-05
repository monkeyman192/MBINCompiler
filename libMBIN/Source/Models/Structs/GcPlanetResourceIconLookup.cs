namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x118)]
    public class GcPlanetResourceIconLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public TkTextureResource Icon;
        public TkTextureResource IconBinocs;
    }
}
