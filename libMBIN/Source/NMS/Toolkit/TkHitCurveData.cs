using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x324B0B3907C18BEF, NameHash = 0xA954F03559C40EB5)]
    public class TkHitCurveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkInOutCurve Curve;
        [NMS(Index = 0)]
        /* 0x8 */ public float Time;
    }
}
