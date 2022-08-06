using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC973597A8E23689F, NameHash = 0x5F02C151C26450C8)]
    public class TkCoordinateOrientation : NMSTemplate
    {
        // size: 0x2
        public enum CoordinateOrientationEnum { None, Random }
        public CoordinateOrientationEnum CoordinateOrientation;
    }
}
