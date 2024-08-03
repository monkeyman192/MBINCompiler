using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x728200688AF730A5, NameHash = 0xF52E26A7)]
    public class GcDiscoveryTrimScoringRules : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float MaxScoreValue;
        [NMS(Index = 0)]
        /* 0x4 */ public float MinScoreValue;
        [NMS(Index = 2)]
        /* 0x8 */ public TkCurveType Curve;
    }
}
