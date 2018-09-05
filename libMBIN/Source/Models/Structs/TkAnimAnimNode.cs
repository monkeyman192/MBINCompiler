namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x70)]
    public class TkAnimAnimNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string NodeId;
        [NMS(Size = 0x10)]
        public string AnimId;
        [NMS(Size = 0x40)]
        public string PhaseIn;
        public TkCurveType PhaseCurve;
        public float PhseRangeBegin;
        public float PhaseRangeEnd;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
