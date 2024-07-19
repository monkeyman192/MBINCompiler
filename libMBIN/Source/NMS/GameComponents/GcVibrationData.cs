using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C3D17C663E1577C, NameHash = 0x37C3B9C6)]
    public class GcVibrationData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float DecayTime;
        [NMS(Index = 0)]
        /* 0x04 */ public float OutputStrength;
        [NMS(Index = 5)]
        /* 0x08 */ public float SmoothTime;
        [NMS(Index = 3)]
        /* 0x0C */ public float Variance;
        [NMS(Index = 4)]
        /* 0x10 */ public float VarianceContrast;
        [NMS(Index = 1)]
        /* 0x14 */ public TkCurveType OutputStrengthCurve;
    }
}
