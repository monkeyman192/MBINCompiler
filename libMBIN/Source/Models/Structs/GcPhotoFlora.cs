namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcPhotoFlora : NMSTemplate
    {
        public short AmountMin;
        public short AmountMax;
        public GcPhotoPlant PlanetType;
    }
}
