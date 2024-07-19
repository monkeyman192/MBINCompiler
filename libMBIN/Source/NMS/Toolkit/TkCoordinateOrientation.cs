namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1AEBC22B3DE06B75, NameHash = 0xEA11CE48)]
    public class TkCoordinateOrientation : NMSTemplate
    {
        // size: 0x2
        public enum CoordinateOrientationEnum : uint {
            None,
            Random,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CoordinateOrientationEnum CoordinateOrientation;
    }
}
