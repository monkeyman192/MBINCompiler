namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36BCC2C1C110521, NameHash = 0x5BB6B87A77237F5E)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 MissionID;
        /* 0x010 */ public NMSString0x80 DebugText;
        /* 0x090 */ public NMSString0x80 Message;
        /* 0x110 */ public bool Forced;
        /* 0x111 */ public bool MakeCurrent;
        /* 0x112 */ public bool Restart;
    }
}
