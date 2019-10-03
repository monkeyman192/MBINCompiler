using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3, GUID = 0x7E964EBCC31CF4FD, NameHash = 0x9EACE51885CC7760)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        public bool IsExtreme;
        public bool StormActive;
        public bool IgnoreStormIfInShip;
    }
}
