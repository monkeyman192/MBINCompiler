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
        public int Coordinates;
        public string[] CoordinatesValues()
        {
            return new[] { "Polar", "Cartesian"};
        }
        public int BlendOp;
        public string[] BlendOpValues()
        {
            return new[] { "Blend", "Add" };
        }
        public List<TkAnim2dBlendNodeData> BlendChildren;
    }
}
