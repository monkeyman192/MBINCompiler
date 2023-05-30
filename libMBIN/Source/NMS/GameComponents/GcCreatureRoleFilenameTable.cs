using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Size = 9, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Test", "All" })]
        public GcCreatureRoleFilenameList[] BiomeFiles;

        public GcCreatureRoleFilenameList UnderwaterBiomeFiles; // todo: find what these are actually named, these are just guesses atm
        public GcCreatureRoleFilenameList CaveBiomeFiles;
        public GcCreatureRoleFilenameList AirBiomeFiles;
        public GcCreatureRoleFilenameList GroundBiomeFiles;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        public float[] LifeChance;
    }
}
