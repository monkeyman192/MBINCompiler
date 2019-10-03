using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x1E174AAC81BFAF86, NameHash = 0xB150A87B0DD42807)]
    public class GcDistanceScaleComponentData : NMSTemplate
    {
        public bool UseGlobals;
        public float Scale;
        public float MinDistance;
        public float MaxDistance;
        public float MinHeight;
        public float MaxHeight;
        public bool DisabledWhenOnFreighter;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
