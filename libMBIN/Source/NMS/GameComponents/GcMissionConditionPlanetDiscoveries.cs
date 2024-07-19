using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8790A77F85EC5FB, NameHash = 0x9F74C96A)]
    public class GcMissionConditionPlanetDiscoveries : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcDiscoveryType DiscoveryType;
        [NMS(Index = 1)]
        /* 0x4 */ public float PercentDiscovered;
        [NMS(Index = 2)]
        /* 0x8 */ public bool DeepSearchDoneDiscos;
    }
}
