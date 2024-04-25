using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x414C922F72D16827, NameHash = 0xDDDC2F57D70378EB)]
    public class GcNPCSettlementBehaviourObjectTypeWeightEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcNPCInteractiveObjectType ObjectType;
        [NMS(Index = 1)]
        /* 0x4 */ public float Weight;
    }
}
