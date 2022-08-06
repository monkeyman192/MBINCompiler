using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5114BC010AE35BF2, NameHash = 0xAD03B051106BCE0A)]
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
		public enum GlobalMissionEnum { Atlas, BlackHole, Anomaly, Explore }
		public GlobalMissionEnum GlobalMission;
    }
}