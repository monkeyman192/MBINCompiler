namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB60BE1132B2E286E, NameHash = 0x5755416737105B76)]
    public class GcMissionSequenceFreighterEngage : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x10 TimeoutMessage;
        [NMS(Index = 2)]
        /* 0x010 */ public float EngageDistance;
        [NMS(Index = 3)]
        /* 0x014 */ public float EngageTime;
        [NMS(Index = 4)]
        /* 0x018 */ public float TimeAfterWarp;
        [NMS(Index = 7)]
        /* 0x01C */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x09C */ public NMSString0x80 MessageEngage;
        [NMS(Index = 0)]
        /* 0x11C */ public NMSString0x80 MessageGetToSpace;
        [NMS(Index = 6)]
        /* 0x19C */ public NMSString0x80 TimeoutOSDMessage;
    }
}
