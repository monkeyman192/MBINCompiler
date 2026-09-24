using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30A2F5F98E161786, NameHash = 0x4E2556EB)]
    public class GcMissionTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "MissionID")]
        /* 0x0 */ public HashMap<GcGenericMissionSequence> Missions;
    }
}
