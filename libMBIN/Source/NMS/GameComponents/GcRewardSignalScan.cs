using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCA1A08C2974D9E1, NameHash = 0xEDA5BCF252E3B6EF)]
    public class GcRewardSignalScan : NMSTemplate
    {
		public enum SignalScanTypeEnum { None, DropPod, Shelter, Search, Relic, Industrial, Alien, CrashedFreighter }
		public SignalScanTypeEnum SignalScanType;
    }
}
