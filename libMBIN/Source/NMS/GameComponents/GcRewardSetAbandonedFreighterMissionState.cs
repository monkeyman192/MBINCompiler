using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x15C9A3F1B16AC981, NameHash = 0xDEABEB9DAFEFB3D9)]
    public class GcRewardSetAbandonedFreighterMissionState : NMSTemplate
    {
		public enum AbandonedFreighterMissionStateEnum { EndRoomComplete, CrewManifestRead, CaptainsLogRead, HazardOn, SlowWalkOn, OpenDoors }
		/* 0x0 */ public AbandonedFreighterMissionStateEnum AbandonedFreighterMissionState;
        /* 0x4 */ public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] EndPadding;
    }
}
