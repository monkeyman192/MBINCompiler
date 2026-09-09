namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFEA4A409E835410, NameHash = 0x6E736DB7)]
    public class GcMissionConditionIsMissionInProgress : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MissionID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool MustBeSelectedMission;
    }
}
