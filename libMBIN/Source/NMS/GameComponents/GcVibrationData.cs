using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x181CDFB6B5D7A1BE, NameHash = 0x1C317C9CAD203EF4)]
    public class GcVibrationData : NMSTemplate
    {
        public float OutputStrength;
        public TkCurveType OutputStrengthCurve;
        public float DecayTime;
        public float Variance;
        public float VarianceContrast;
        public float SmoothTime;
    }
}
