using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x9F0B6CF8AD454951, NameHash = 0xC28C1E8A4FA47E3B)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string MissionID;
    }
}
