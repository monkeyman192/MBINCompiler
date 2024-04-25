using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E9E0BF40D86E476, NameHash = 0x83F2CB797BB763BC)]
    public class GcMissionConditionMissionStatValue : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong MissionStatValue;
        [NMS(Index = 1)]
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
