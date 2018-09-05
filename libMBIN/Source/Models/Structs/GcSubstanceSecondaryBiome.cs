namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1A0)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        [NMS(Size = 0xD, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        public GcSubstanceSecondary[] SecondarySubstanceByBiome;

    }
}
