using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcColourModifier : NMSTemplate
    {
        public bool ForceColour;
        public Colour ForceColourTo;
        public float OffsetSaturation;
        public float OffsetValue;
        public float MultiplySaturation;
        public float MultiplyValue;
    }
}
