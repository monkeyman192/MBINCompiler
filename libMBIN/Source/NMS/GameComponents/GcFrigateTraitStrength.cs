namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0B0A7490B06DF04, NameHash = 0x728D923)]
    public class GcFrigateTraitStrength : NMSTemplate
    {
        // size: 0xA
        public enum FrigateTraitStrengthEnum : uint {
            NegativeLarge,
            NegativeMedium,
            NegativeSmall,
            TertiarySmall,
            TertiaryMedium,
            TertiaryLarge,
            SecondarySmall,
            SecondaryMedium,
            SecondaryLarge,
            Primary,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateTraitStrengthEnum FrigateTraitStrength;
    }
}
