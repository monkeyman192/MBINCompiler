using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF6BEA6720082E7B, NameHash = 0x87BC5043F293743D)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum))]
        /* 0x000 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
        [NMS(Index = 0)]
        /* 0x168 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
    }
}
