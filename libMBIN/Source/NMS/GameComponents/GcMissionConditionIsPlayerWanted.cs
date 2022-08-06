using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x94BE14A6488F8913, NameHash = 0x470EE61C4698CBB9)]
    public class GcMissionConditionIsPlayerWanted : NMSTemplate
    {
        public int Level;
        public TkEqualityEnum Test;
    }
}