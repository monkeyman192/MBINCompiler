namespace MBINCompiler.Models.Structs
{
    public class GcGameMode : NMSTemplate
    {
        public int PresetGameMode;
        public string[] PresetGameModeValues()
        {
            return new[] { "Unspecified", "Normal", "Creative", "Survival" };
        }
    }
}
