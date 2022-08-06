using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x41FEBAC9A23EF9D6, NameHash = 0xD14651666CB8A6EB)]
    public class GcDiscoveryHelperTimings : NMSTemplate // size = 0xC
    {

        public float DiscoverPlanetTotalTime;           // 41200000h
        public float DiscoverPlanetMessageWait;         // 3F800000h
        public float DiscoverPlanetMessageTime;         // 40E00000h
    }
}