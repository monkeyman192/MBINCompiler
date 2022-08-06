using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45D1408457CC38ED, NameHash = 0x36730B94549148DE)]
    public class GcNPCSettlementBehaviourState : NMSTemplate
    {
        // size: 5
        public enum NPCSettlementBehaviourStateEnum { generic, Sociable, Productive, Tired, Afraid }
        public NPCSettlementBehaviourStateEnum NPCSettlementBehaviourState;
    }
}
