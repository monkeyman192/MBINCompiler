using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x97C39F7775C60439, NameHash = 0xB08E12209E446AC4)]
    public class TkAnim2dBlendNode : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NodeId;
        /* 0x10 */ public NMSString0x40 PositionIn;
        /* 0x50 */ public float PositionRangeBegin;
        /* 0x54 */ public float PositionRangeEnd;
        /* 0x58 */ public float PositionSpringTime;
        /* 0x5C */ public TkCurveType PositionCurve;
        // size: 0x2
        public enum CoordinatesEnum : uint {
            Polar,
            Cartesian,
        }
        /* 0x60 */ public CoordinatesEnum Coordinates;
        // size: 0x2
        public enum BlendOpEnum : uint {
            Blend,
            Add,
        }
        /* 0x64 */ public BlendOpEnum BlendOp;
        /* 0x68 */ public List<TkAnim2dBlendNodeData> BlendChildren;
    }
}
