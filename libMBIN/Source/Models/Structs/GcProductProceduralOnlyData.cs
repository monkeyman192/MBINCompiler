namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x38)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        public int DropWeight;
        public int BasevalueMin;
        public int BaseValueMax;
        public int AgeMin;
        public int AgeMax;
        public GcNumberedTextList Descriptions;
    }
}
