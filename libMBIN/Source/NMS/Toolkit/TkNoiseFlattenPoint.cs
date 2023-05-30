using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseFlattenPoint : NMSTemplate  // 0x28 bytes
    {
        public float Density;
        public float FlattenRadius;
        public float TurbulenceFrequency;
        public float TurbulenceAmplitude;
        public int TurbulenceOctaves;
        public TkNoiseFlattenOptions FlattenType;
        public int Classification;
        public int Placement;
        public bool AddWaypoint;
        public bool AddShelter;
        public bool AddLandingPad;

        [NMS(Size = 1, Ignore = true)]
        public byte[] Padding27;
    }
}
