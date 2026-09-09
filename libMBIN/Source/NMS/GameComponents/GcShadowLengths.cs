namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F9B2067711C9279, NameHash = 0x212D3514)]
    public class GcShadowLengths : NMSTemplate
    {
        // size: 0x8
        public enum ShadowLengthsEnum : uint {
            Surface,
            Ship,
            Space,
            SpacePOI,
            Station,
            Freighter,
            FreighterAbandoned,
            CameraView,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShadowLengthsEnum ShadowLengths;
    }
}
