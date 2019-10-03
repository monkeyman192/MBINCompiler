using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xF8, GUID = 0x7886A38513257F16, NameHash = 0xA394D25E5A975DA5)]
    public class TkAnimBlendNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string NodeId;
        [NMS(Size = 0x40)]
        /* 0x10 */ public string WeightIn;
        /* 0x50 */ public float WeightRangeBegin;
        /* 0x54 */ public float WeightRangeEnd;
        /* 0x58 */ public float WeightSpringTime;
        /* 0x5C */ public TkCurveType WeightCurve;
        /* 0x60 */ public float InitialWeight;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x64 */ public byte[] Padding64;
        /* 0x68 */ public NMSTemplate BlendLeft;
        /* 0xB0 */ public NMSTemplate BlendRight;
    }
}
