namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F900AB5852DB385, NameHash = 0xCC1A2EAE)]
    public class GcMissionSequenceFreighterEngage : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString MessageEngage;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString MessageGetToSpace;
        [NMS(Index = 5)]
        /* 0x30 */ public NMSString0x10 TimeoutMessage;
        [NMS(Index = 6)]
        /* 0x40 */ public VariableSizeString TimeoutOSDMessage;
        [NMS(Index = 2)]
        /* 0x50 */ public float EngageDistance;
        [NMS(Index = 3)]
        /* 0x54 */ public float EngageTime;
        [NMS(Index = 4)]
        /* 0x58 */ public float TimeAfterWarp;
    }
}
