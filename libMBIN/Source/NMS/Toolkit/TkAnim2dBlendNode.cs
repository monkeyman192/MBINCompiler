using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x58705CF287339939, NameHash = 0xA7619C09)]
    public class TkAnim2dBlendNode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 NodeId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 PositionIn;
        [NMS(Index = 2)]
        /* 0x50 */ public float PositionRangeBegin;
        [NMS(Index = 3)]
        /* 0x54 */ public float PositionRangeEnd;
        [NMS(Index = 4)]
        /* 0x58 */ public float PositionSpringTime;
        [NMS(Index = 5)]
        /* 0x5C */ public TkCurveType PositionCurve;
        [NMS(Index = 6)]
        /* 0x5D */ public bool SelectBlend;
        [NMS(Index = 7)]
        /* 0x60 */ public float SelectBlendSpring;
        // size: 0x2
        public enum CoordinatesEnum : uint {
            Polar,
            Cartesian,
        }
        [NMS(Index = 8)]
        /* 0x64 */ public CoordinatesEnum Coordinates;
        // size: 0x2
        public enum BlendOpEnum : uint {
            Blend,
            Add,
        }
        [NMS(Index = 9)]
        /* 0x68 */ public BlendOpEnum BlendOp;
        [NMS(Index = 10)]
        /* 0x70 */ public List<TkAnim2dBlendNodeData> BlendChildren;
    }
}
