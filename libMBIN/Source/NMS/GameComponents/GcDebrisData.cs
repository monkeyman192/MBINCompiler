using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDebrisData : NMSTemplate
    {
        public TkModelResource Filename;
        public int Number;
        public float Radius;
        public float Scale;
        public float Speed;
        public float AnglularSpeed; // sic
    }
}
