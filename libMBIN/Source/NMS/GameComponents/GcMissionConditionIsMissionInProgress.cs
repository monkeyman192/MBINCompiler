using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B10DBFD4FED9F84, NameHash = 0x8FA593E74FC53DD5)]
    public class GcMissionConditionIsMissionInProgress : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool MustBeSelectedMission;
    }
}
