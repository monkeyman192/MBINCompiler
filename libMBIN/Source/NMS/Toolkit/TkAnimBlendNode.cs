using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB5B5A9B426511FBB, NameHash = 0xA394D25E5A975DA5)]
    public class TkAnimBlendNode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 NodeId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 WeightIn;
        [NMS(Index = 2)]
        /* 0x50 */ public float WeightRangeBegin;
        [NMS(Index = 3)]
        /* 0x54 */ public float WeightRangeEnd;
        [NMS(Index = 4)]
        /* 0x58 */ public float WeightSpringTime;
        [NMS(Index = 5)]
        /* 0x5C */ public TkCurveType WeightCurve;
        [NMS(Index = 6)]
        /* 0x60 */ public float InitialWeight;
        [NMS(Index = 7)]
        /* 0x68 */ public NMSTemplate BlendLeft;
        [NMS(Index = 8)]
        /* 0xB8 */ public NMSTemplate BlendRight;
    }
}
