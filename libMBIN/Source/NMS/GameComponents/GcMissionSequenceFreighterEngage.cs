namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58BA8A8354A7C52B, NameHash = 0x5755416737105B76)]
    public class GcMissionSequenceFreighterEngage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 TimeoutMessage;
        /* 0x010 */ public float EngageDistance;
        /* 0x014 */ public float EngageTime;
        /* 0x018 */ public float TimeAfterWarp;
        /* 0x01C */ public NMSString0x80 DebugText;
        /* 0x09C */ public NMSString0x80 MessageEngage;
        /* 0x11C */ public NMSString0x80 MessageGetToSpace;
        /* 0x19C */ public NMSString0x80 TimeoutOSDMessage;
    }
}
