namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x154451FF156017FD, NameHash = 0x5BB6B87A77237F5E)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 MissionID;
        [NMS(Index = 5)]
        /* 0x010 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x090 */ public NMSString0x80 Message;
        [NMS(Index = 4)]
        /* 0x110 */ public bool Forced;
        [NMS(Index = 2)]
        /* 0x111 */ public bool MakeCurrent;
        [NMS(Index = 3)]
        /* 0x112 */ public bool Restart;
    }
}
