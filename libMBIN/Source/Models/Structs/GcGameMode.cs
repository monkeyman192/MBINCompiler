namespace libMBIN.Models.Structs
{
    public class GcGameMode : NMSTemplate
    {
		public enum PresetGameModeEnum { Unspecified, Normal, Creative, Survival, Ambient, Permadeath }
		public PresetGameModeEnum PresetGameMode;
    }
}
