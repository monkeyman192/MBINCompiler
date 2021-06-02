using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x78, GUID = 0x1B8A8FEEDBCC6340, NameHash = 0xB08E12209E446AC4)]
    public class TkAnim2dBlendNode : NMSTemplate
    {
        public NMSString0x10 NodeId;
        public NMSString0x40 PositionIn;
        public float PositionRangeBegin;
        public float PositionRangeEnd;
        public float PositionSpringTime;
        public TkCurveType PositionCurve;
		public enum CoordinatesEnum { Polar, Cartesian }
		public CoordinatesEnum Coordinates;
		public enum BlendOpEnum { Blend, Add }
		public BlendOpEnum BlendOp;
        public List<TkAnim2dBlendNodeData> BlendChildren;
    }
}
