using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x324B0B3907C18BEF, NameHash = 0xA954F03559C40EB5)]
    public class TkHitCurveData : NMSTemplate
    {
        /* 0x0 */ public TkInOutCurve Curve;
        /* 0x8 */ public float Time;
    }
}
