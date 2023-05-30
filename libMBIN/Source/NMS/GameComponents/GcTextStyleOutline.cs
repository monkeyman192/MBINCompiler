using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTextStyleOutline : NMSTemplate
    {
        public Colour OutlineColour;
        public Vector2f OutlineOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
