using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C683D6090263BFD, NameHash = 0xB22694B55382153C)]
    public class GcMissionConditionSystemPlanetTest : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcBiomeType PlanetBiomeRequirement;
        [NMS(Index = 1)]
        /* 0x4 */ public GcPlayerHazardType PlanetWeatherRequirement;
        [NMS(Index = 0)]
        /* 0x8 */ public bool RequiresExtremePlanet;
    }
}
