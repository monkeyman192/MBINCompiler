using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC9B4A9F531E84B81, NameHash = 0x2128EDF6E38E9344)]
    public class GcLandingHelperComponentData : NMSTemplate
    {
        public float ActiveDistanceMin;
        public float ActiveDistanceMax;
        public bool LandPoint;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding9;
    }
}
