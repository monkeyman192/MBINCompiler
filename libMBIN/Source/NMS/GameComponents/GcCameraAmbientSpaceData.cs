using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x872B03D69317AF30, NameHash = 0x3B1EFAD66E07132E)]
    public class GcCameraAmbientSpaceData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
		public enum OriginEnum { SpaceStationInternals, SpaceStationBack, FreighterBattle, Freighter, FreighterHangar, AtlasStation, BlackHole, Anomaly }
		/* 0x20 */ public OriginEnum Origin;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
