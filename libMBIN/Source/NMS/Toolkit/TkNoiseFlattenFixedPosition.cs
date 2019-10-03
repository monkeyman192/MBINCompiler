using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0xF624181EB43DF37B, NameHash = 0x5BFC087E90D1520B)]
    public class TkNoiseFlattenFixedPosition : NMSTemplate
    {
        public Vector4f Position;

        public TkNoiseFlattenPoint FlattenPoint;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
