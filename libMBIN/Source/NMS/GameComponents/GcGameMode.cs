using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4908B03210959014, NameHash = 0x2BFE76ABF5398879)]
    public class GcGameMode : NMSTemplate
    {
		public enum PresetGameModeEnum { Unspecified, Normal, Creative, Survival, Ambient, Permadeath }
		public PresetGameModeEnum PresetGameMode;
    }
}
