using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x51522AC6C0C2B90D, NameHash = 0x2A8282CD4FA96596)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        public GcStatsTypes TargetStat;
        public int Amount;
        [NMS(Size = 0x10)]
        public string SpecificTechID;
    }
}
