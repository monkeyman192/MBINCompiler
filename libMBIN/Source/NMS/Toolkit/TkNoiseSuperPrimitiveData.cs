using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xA5204789BF9D0341, NameHash = 0x863E7456C3844AC)]
    public class TkNoiseSuperPrimitiveData : NMSTemplate        // size: 0x1C       // also maybe part of a global?
    {
        public float Width;
        public float Height;
        public float Depth;
        public float Thickness;
        public float CornerRadiusXY;
        public float CornerRadiusZ;
        public float BottomRadiusOffset;
    }
}
