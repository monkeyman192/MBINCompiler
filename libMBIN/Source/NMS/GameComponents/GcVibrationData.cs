using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8D7D8F0ECE4DB7B, NameHash = 0x1C317C9CAD203EF4)]
    public class GcVibrationData : NMSTemplate
    {
        /* 0x00 */ public float DecayTime;
        /* 0x04 */ public float OutputStrength;
        /* 0x08 */ public float SmoothTime;
        /* 0x0C */ public float Variance;
        /* 0x10 */ public float VarianceContrast;
        /* 0x14 */ public TkCurveType OutputStrengthCurve;
    }
}
