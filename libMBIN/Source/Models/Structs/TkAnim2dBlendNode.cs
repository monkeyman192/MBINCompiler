using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x78)]
    public class TkAnim2dBlendNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string NodeId;
        [NMS(Size = 0x40)]
        public string PositionIn;
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
