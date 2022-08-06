using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4BE1B6BC289E2D1C, NameHash = 0xE607B9EEA91E2AD5)]
    public class GcSpaceshipAvoidanceData : NMSTemplate
    {
        public int NumRays;
        public float RayMinRange;
        public float RaySpeedTime;
        public float Force;
        public float StartRadiusMultiplier;
        public float EndRadiusMultiplier;
        public float SpeedInterp;
        public float SpeedInterpMinSpeed;
        public float SpeedInterpRange;
    }
}
