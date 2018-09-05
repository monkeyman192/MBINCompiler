namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x34)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0xD, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        public float[] BiomeProbability;
    }
}
