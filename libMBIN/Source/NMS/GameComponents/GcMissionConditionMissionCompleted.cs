using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, Alignment = 0x8, GUID = 0x9F0B6CF8AD454951, NameHash = 0xC28C1E8A4FA47E3B)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
    }
}