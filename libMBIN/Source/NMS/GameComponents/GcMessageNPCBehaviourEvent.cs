using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x299DC08D290667D3, NameHash = 0x40F7E71C83A33DA0)]
    public class GcMessageNPCBehaviourEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 BehaviourEvent;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 UserData;
        [NMS(Index = 3)]
        /* 0x30 */ public int InteractionSubType;
        [NMS(Index = 2)]
        /* 0x34 */ public GcNPCTriggerTypes InteractionTrigger;
        [NMS(Index = 5)]
        /* 0x38 */ public GcNodeID SourceNode;
    }
}
