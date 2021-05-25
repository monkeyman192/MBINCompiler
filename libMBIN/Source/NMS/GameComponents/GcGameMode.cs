using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x12B8A9683D0E67A4, NameHash = 0x2BFE76ABF5398879)]
    public class GcGameMode : NMSTemplate
    {
        // size: 0x7
		public enum PresetGameModeEnum { Unspecified, Normal, Creative, Survival, Ambient, Permadeath, Seasonal }
		public PresetGameModeEnum PresetGameMode;
    }
}