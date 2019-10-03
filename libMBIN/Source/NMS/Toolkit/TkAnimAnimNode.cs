using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x70, GUID = 0xB911CEB4CA3E7843, NameHash = 0xEC73620F98D708BF)]
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
