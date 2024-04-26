using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B8CE7C7D99B1A09, NameHash = 0x9438A8C0CC009F4)]
    public class GcNPCSettlementBehaviourAreaPropertyWeightEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcNPCSettlementBehaviourAreaProperty AreaProperty;
        [NMS(Index = 1)]
        /* 0x4 */ public float EntryWeight;
        [NMS(Index = 2)]
        /* 0x8 */ public float ExitWeight;
    }
}
