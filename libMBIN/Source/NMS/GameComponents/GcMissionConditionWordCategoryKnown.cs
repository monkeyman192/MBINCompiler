using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x99908A551B2C772B, NameHash = 0xC1BA5468EA0625B9)]
    public class GcMissionConditionWordCategoryKnown : NMSTemplate
    {
        public GcWordCategoryTableEnum Category;
        public GcAlienRace Race;
    }
}
