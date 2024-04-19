using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA0C587EC17860FF, NameHash = 0x9EACE51885CC7760)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        /* 0x0 */ public GcPlayerHazardType WeatherRequirement;
        /* 0x4 */ public bool AllowNonHazardExtremeIfNoStorms;
        /* 0x5 */ public bool IgnoreStormIfInShip;
        /* 0x6 */ public bool IsExtreme;
        /* 0x7 */ public bool StormActive;
    }
}
