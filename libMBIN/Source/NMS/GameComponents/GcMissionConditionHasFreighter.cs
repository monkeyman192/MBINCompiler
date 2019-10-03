using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x6B55DA1A2BA483CF, NameHash = 0x8563E3CD9630D9C)]
    public class GcMissionConditionHasFreighter : NMSTemplate
    {
		public enum FreighterInCurrentSystemEnum { DontCare, Yes, No }
		public FreighterInCurrentSystemEnum FreighterInCurrentSystem;
    }
}
