using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMissionDifficulty : NMSTemplate
    {
		public enum MissionDifficultyEnum { Easy, Normal, Hard }
		public MissionDifficultyEnum MissionDifficulty;
    }
}
