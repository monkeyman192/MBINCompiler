namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE0743B4909D405A, NameHash = 0xE36FB5A8)]
    public class GcNPCSettlementBehaviourState : NMSTemplate
    {
        // size: 0x5
        public enum NPCSettlementBehaviourStateEnum : uint {
            Generic,
            Sociable,
            Productive,
            Tired,
            Afraid,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCSettlementBehaviourStateEnum NPCSettlementBehaviourState;
    }
}
