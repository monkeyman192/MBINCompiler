namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1C)]
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
