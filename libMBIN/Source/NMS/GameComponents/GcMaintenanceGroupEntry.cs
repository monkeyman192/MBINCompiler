using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x148453DE61194BB0, NameHash = 0x4796039B)]
    public class GcMaintenanceGroupEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public float OverrideAmount;
        [NMS(Index = 2)]
        /* 0x14 */ public float ProbabilityWeighting;
        [NMS(Index = 0)]
        /* 0x18 */ public GcInventoryType Type;
    }
}
