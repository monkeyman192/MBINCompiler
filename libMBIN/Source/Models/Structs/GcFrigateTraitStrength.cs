namespace libMBIN.Models.Structs
{
    public class GcFrigateTraitStrength : NMSTemplate
    {
		public enum FrigateTraitStrengthEnum { NegativeLarge, NegativeMedium, NegativeSmall, TertiarySmall, TertiaryMedium, TertiaryLarge, SecondarySmall, SecondaryMedium, SecondaryLarge, Primary }
		public FrigateTraitStrengthEnum FrigateTraitStrength;
    }
}
