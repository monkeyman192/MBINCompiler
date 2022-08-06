using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x15C9A3F1B16AC981, NameHash = 0xDEABEB9DAFEFB3D9)]
    public class GcRewardSetAbandonedFreighterMissionState : NMSTemplate
    {
		public enum AbandonedFreighterMissionStateEnum { EndRoomComplete, CrewManifestRead, CaptainsLogRead, HazardOn, SlowWalkOn, OpenDoors }
		/* 0x0 */ public AbandonedFreighterMissionStateEnum AbandonedFreighterMissionState;
        /* 0x4 */ public bool Silent;
    }
}
