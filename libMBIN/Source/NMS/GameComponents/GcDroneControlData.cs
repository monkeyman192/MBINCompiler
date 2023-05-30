using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDroneControlData : NMSTemplate
    {
        public float MaxSpeed;
        public float Strength;
        public float DirectionBrake;
        public float MinHeight;
        public float MaxHeight;
        public float HeightAdjustStrength;
        public float HeightAdjustDownStrength;
        public float LookStrength;
        public float StopTime;
        public float RepelForce;
        public float RepelRange;
    }
}
