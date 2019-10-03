using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDCBE9A734927C416, NameHash = 0x529C5D98B446B5B2)]
    public class GcCostStanding : NMSTemplate
    {
        public GcAlienRace AlienRace;
        public int RequiredStanding;
    }
}
