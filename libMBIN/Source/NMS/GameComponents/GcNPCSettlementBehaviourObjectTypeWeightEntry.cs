using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53F1251A0B78A5DF, NameHash = 0xDDDC2F57D70378EB)]
    public class GcNPCSettlementBehaviourObjectTypeWeightEntry : NMSTemplate
    {
        /* 0x0 */ public GcNPCInteractiveObjectType ObjectType;
        /* 0x4 */ public float Weight;
    }
}
