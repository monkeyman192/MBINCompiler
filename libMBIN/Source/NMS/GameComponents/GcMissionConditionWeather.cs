using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA0C587EC17860FF, NameHash = 0x9EACE51885CC7760)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcPlayerHazardType WeatherRequirement;
        [NMS(Index = 4)]
        /* 0x4 */ public bool AllowNonHazardExtremeIfNoStorms;
        [NMS(Index = 3)]
        /* 0x5 */ public bool IgnoreStormIfInShip;
        [NMS(Index = 0)]
        /* 0x6 */ public bool IsExtreme;
        [NMS(Index = 2)]
        /* 0x7 */ public bool StormActive;
    }
}
