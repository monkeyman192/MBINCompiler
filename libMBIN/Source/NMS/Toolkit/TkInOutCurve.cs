using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x323106FDDDE6667, NameHash = 0x37F732EF5C0B44F6)]
    public class TkInOutCurve : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Midpoint;
        [NMS(Index = 1)]
        /* 0x4 */ public TkCurveType InCurve;
        [NMS(Index = 2)]
        /* 0x5 */ public TkCurveType OutCurve;
    }
}
