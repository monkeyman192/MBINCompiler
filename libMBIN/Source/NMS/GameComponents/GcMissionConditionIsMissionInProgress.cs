using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, Alignment = 0x8, GUID = 0xA3387EE10E7D102C, NameHash = 0x8FA593E74FC53DD5)]
    public class GcMissionConditionIsMissionInProgress : NMSTemplate
    {
        /* 0x0 */ public NMSString0x10 MissionID;
    }
}
