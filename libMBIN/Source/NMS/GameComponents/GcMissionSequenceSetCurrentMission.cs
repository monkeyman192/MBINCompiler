namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x757BABEAD0929E5E, NameHash = 0x7626799B)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 MissionID;
        [NMS(Index = 1)]
        /* 0x20 */ public bool FirstIncompleteMilestone;
        [NMS(Index = 2)]
        /* 0x21 */ public bool Silent;
    }
}
