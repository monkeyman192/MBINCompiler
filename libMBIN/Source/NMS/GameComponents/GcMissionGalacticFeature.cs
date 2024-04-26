namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC98E74091146C414, NameHash = 0x60EEF97D074917CD)]
    public class GcMissionGalacticFeature : NMSTemplate
    {
        // size: 0x3
        public enum GalacticFeatureEnum : uint {
            Anomaly,
            Atlas,
            BlackHole,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalacticFeatureEnum GalacticFeature;
    }
}
