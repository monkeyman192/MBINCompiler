using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB8, GUID = 0x2860E63449C8ACD8, NameHash = 0x541BE758514502E3)]
    public class TkAnimVectorBlendNodeData : NMSTemplate
    {
        public NMSString0x10 NodeId;
        public NMSString0x40 WeightIn;
        public float WeightRangeBegin;
        public float WeightRangeEnd;
        public float WeightSpringTime;
        public TkCurveType WeightCurve;
        public float InitialWeight;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding64;
        public NMSTemplate BlendChild;
    }
}
