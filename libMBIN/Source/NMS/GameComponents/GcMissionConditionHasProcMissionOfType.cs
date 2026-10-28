using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x295A90FB64ED18BD, NameHash = 0x38B5596C)]
    public class GcMissionConditionHasProcMissionOfType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionType Type;
    }
}
