namespace libMBIN.Models.Structs
{
    public class GcFrigateTraitStrength : NMSTemplate
    {
        public int FrigateTraitStrength;
        public string[] FrigateTraitStrengthValues()
        {
            return new[] { "NegativeLarge", "NegativeMedium", "NegativeSmall", "TertiarySmall", "TertiaryMedium", "TertiaryLarge",
                           "SecondarySmall", "SecondaryMedium", "SecondaryLarge", "Primary" };
        }
    }
}
