using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x114B7C2B8D22F51, NameHash = 0x25C87553CE78E1FD)]
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