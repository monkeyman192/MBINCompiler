namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcSubstanceAmount : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        [NMS(Size = 0x10)]
        public string Specific;
        [NMS(Size = 0x10)]
        public string SpecificSecondary;

        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
    }
}
