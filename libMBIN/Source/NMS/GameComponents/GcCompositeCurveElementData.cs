using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F758AEFE9DA4357, NameHash = 0x3FE05D76)]
    public class GcCompositeCurveElementData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Duration;
        [NMS(Index = 0)]
        /* 0x4 */ public float EndValue;
        [NMS(Index = 2)]
        /* 0x8 */ public TkCurveType CurveType;
    }
}
