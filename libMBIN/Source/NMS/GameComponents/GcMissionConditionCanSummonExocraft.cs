using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9424DB0B12B4353, NameHash = 0x9E6CDA34B604CC21)]
    public class GcMissionConditionCanSummonExocraft : NMSTemplate
    {
        /* 0x0 */ public GcVehicleType SummonableExocraft;
        /* 0x4 */ public bool SpecificExocraft;
    }
}
