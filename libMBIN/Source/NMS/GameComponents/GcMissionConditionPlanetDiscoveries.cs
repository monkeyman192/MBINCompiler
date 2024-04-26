using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD523F943FA186627, NameHash = 0x792A334D3849EEA1)]
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
