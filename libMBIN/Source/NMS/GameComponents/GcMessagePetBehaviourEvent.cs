using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D2D8D3C12FC11D6, NameHash = 0x6FA87CEA)]
    public class GcMessagePetBehaviourEvent : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector3f Direction;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A UserData;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 BehaviourEvent;
        [NMS(Index = 2)]
        /* 0x50 */ public GcPetBehaviours ForceBehaviour;
        [NMS(Index = 3)]
        /* 0x54 */ public GcAlienMood Mood;
        [NMS(Index = 6)]
        /* 0x58 */ public GcNodeID SourceNode;
    }
}
