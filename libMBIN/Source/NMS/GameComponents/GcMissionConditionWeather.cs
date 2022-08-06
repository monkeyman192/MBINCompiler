using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAAA343CB48DFA0FC, NameHash = 0x9EACE51885CC7760)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        /* 0x0 */ public bool IsExtreme;
        /* 0x4 */ public GcPlayerHazardType WeatherRequirement;
        /* 0x8 */ public bool StormActive;
        /* 0x9 */ public bool IgnoreStormIfInShip;
        /* 0xA */ public bool AllowNonHazardExtremeIfNoStorms;
    }
}
