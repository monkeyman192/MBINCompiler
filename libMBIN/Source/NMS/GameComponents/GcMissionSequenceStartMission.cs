namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10EE5A109C264093, NameHash = 0xCCEA7AC)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 MissionID;
        [NMS(Index = 4)]
        /* 0x30 */ public bool Forced;
        [NMS(Index = 2)]
        /* 0x31 */ public bool MakeCurrent;
        [NMS(Index = 3)]
        /* 0x32 */ public bool Restart;
    }
}
