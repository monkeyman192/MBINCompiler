namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4725CF1C9F5609E, NameHash = 0x660C408F)]
    public class GcCameraAmbientSpaceData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        // size: 0x8
        public enum OriginEnum : uint {
            SpaceStationInternals,
            SpaceStationBack,
            FreighterBattle,
            Freighter,
            FreighterHangar,
            AtlasStation,
            BlackHole,
            Anomaly,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public OriginEnum Origin;
    }
}
