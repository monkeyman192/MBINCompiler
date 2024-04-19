using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4D6768E0079C51CF, NameHash = 0x541BE758514502E3)]
    public class TkAnimVectorBlendNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NodeId;
        /* 0x10 */ public NMSString0x40 WeightIn;
        /* 0x50 */ public float WeightRangeBegin;
        /* 0x54 */ public float WeightRangeEnd;
        /* 0x58 */ public float WeightSpringTime;
        /* 0x5C */ public TkCurveType WeightCurve;
        /* 0x60 */ public float InitialWeight;
        /* 0x68 */ public NMSTemplate BlendChild;
    }
}
