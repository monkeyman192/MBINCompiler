using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7D59746106C3F196, NameHash = 0x28061A0FD187C5EF)]
    public class GcTextStyleShadow : NMSTemplate
    {
        public Colour ShadowColour;
        public Vector2f ShadowOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
