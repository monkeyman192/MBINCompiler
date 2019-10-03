using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x41BC3C0B86CEBAA0, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        public float Speed;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Axis;
    }
}
