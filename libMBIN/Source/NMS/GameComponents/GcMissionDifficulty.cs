using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAFF99D684E9C68AD, NameHash = 0x81EBB5E64823914E)]
    public class GcMissionDifficulty : NMSTemplate
    {
		public enum MissionDifficultyEnum { Easy, Normal, Hard }
		public MissionDifficultyEnum MissionDifficulty;
    }
}
