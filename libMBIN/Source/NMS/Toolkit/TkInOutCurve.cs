using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x18D565165055378B, NameHash = 0xF77AAC8A)]
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
