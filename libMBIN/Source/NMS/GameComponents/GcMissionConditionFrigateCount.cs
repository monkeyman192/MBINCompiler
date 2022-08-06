using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC9FFFC7A5A173EEC, NameHash = 0x81D792A0622C83B1)]
    public class GcMissionConditionFrigateCount : NMSTemplate
    {
        public int FrigateCount;
        public TkEqualityEnum Test;
    }
}