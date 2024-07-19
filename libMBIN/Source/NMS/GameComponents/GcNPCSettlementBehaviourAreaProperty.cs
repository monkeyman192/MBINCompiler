namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58744973BB15A41F, NameHash = 0xD2136707)]
    public class GcNPCSettlementBehaviourAreaProperty : NMSTemplate
    {
        // size: 0x2
        public enum NPCSettlementBehaviourAreaPropertyEnum : uint {
            ContainsPlayer,
            ContainsNPCs,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCSettlementBehaviourAreaPropertyEnum NPCSettlementBehaviourAreaProperty;
    }
}
