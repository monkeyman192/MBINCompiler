using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FE0BCF52E3DBBE7, NameHash = 0x1C317C9CAD203EF4)]
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
