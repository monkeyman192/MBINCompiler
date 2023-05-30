using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTextStyleShadow : NMSTemplate
    {
        public Colour ShadowColour;
        public Vector2f ShadowOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
