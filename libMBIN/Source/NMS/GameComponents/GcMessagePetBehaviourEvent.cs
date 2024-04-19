using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D7AEFE1BF878CE7, NameHash = 0x9465A52B8A2F9FD9)]
    public class GcMessagePetBehaviourEvent : NMSTemplate
    {
        /* 0x00 */ public Vector3f Direction;
        /* 0x10 */ public Vector3f Position;
        /* 0x20 */ public NMSString0x20A UserData;
        /* 0x40 */ public NMSString0x10 BehaviourEvent;
        /* 0x50 */ public GcPetBehaviours ForceBehaviour;
        /* 0x54 */ public GcAlienMood Mood;
        /* 0x58 */ public GcNodeID SourceNode;
    }
}
