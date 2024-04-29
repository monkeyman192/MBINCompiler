using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DB1DB34D4F6EC19, NameHash = 0x63D04F17E4BE7335)]
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
