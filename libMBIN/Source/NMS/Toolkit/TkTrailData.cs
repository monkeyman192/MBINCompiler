using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1C, GUID = 0xA14CF9DF062F6321, NameHash = 0xE0F2CCB358CDA3EE)]
    public class TkTrailData : NMSTemplate
    {
        public float Width;
        public int Points;
        public int MaxPointsPerFrame;
        public float DistanceThreshold;
        public float PointLife;
        public int FrontPoints;
        public float FrontUvEnd;
    }
}
