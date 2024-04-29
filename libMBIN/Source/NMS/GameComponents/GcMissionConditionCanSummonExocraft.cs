using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DC7D5E4E0C70D63, NameHash = 0x9E6CDA34B604CC21)]
    public class GcMissionConditionCanSummonExocraft : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcVehicleType SummonableExocraft;
        [NMS(Index = 0)]
        /* 0x4 */ public bool SpecificExocraft;
    }
}
