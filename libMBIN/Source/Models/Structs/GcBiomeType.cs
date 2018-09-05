namespace libMBIN.Models.Structs
{
    public class GcBiomeType : NMSTemplate
    {
        public int Biome;
        public string[] BiomeValues()
        {
            return new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" };
        }
    }
}
