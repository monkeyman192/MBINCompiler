using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4E8D92A6E3D6301, NameHash = 0x8037450FD0FA54E6)]
    public class GcMissionConditionPrimaryExocraft : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcVehicleType ExocraftType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool MustBeSummonedNearby;
    }
}
