namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcPhotoFauna : NMSTemplate
    {
        public short AmountMin;
        public short AmountMax;
        public GcPhotoCreature CreatureArea;
    }
}
