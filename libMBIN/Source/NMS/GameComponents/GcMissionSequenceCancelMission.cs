namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x581A9A96EC2CAB3A, NameHash = 0x4A136CB7)]
    public class GcMissionSequenceCancelMission : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x20 */ public bool UseSeed;
    }
}
