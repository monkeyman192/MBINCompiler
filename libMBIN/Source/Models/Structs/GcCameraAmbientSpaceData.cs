namespace libMBIN.Models.Structs
{
    public class GcCameraAmbientSpaceData : NMSTemplate     // size: 0x28
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Animation;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DroneAnimation;
		public enum OriginEnum { SpaceStationInternals, SpaceStationBack, FreighterBattle, Freighter, FreighterHangar, AtlasStation, BlackHole, Anomaly }
		public OriginEnum Origin;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
