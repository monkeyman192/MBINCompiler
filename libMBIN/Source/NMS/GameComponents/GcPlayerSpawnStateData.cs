using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x28585643215796C6, NameHash = 0x6F8C3831DC1540EC)]
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        /* 0x00 */ public Vector4f PlayerPositionInSystem;
        /* 0x10 */ public Vector4f PlayerTransformAt;
        /* 0x20 */ public Vector4f ShipPositionInSystem;
        /* 0x30 */ public Vector4f ShipTransformAt;
		// size: 0x6
        public enum LastKnownPlayerStateEnum { OnFoot, InShip, InStation, AboardFleet, InNexus, AbandonedFreighter }
		public LastKnownPlayerStateEnum LastKnownPlayerState;
		/* 0x50 */ public Vector4f FreighterPositionInSystem;
		/* 0x60 */ public Vector4f FreighterTransformAt;
		/* 0x70 */ public Vector4f FreighterTransformUp;
 		/* 0x80 */ public Vector4f AbandonedFreighterPositionInSystem;
		/* 0x90 */ public Vector4f AbandonedFreighterTransformAt;
		/* 0xA0 */ public Vector4f AbandonedFreighterTransformUp;
    }
}
