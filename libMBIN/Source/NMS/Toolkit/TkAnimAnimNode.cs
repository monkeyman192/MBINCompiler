using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x70, GUID = 0xB911CEB4CA3E7843, NameHash = 0xEC73620F98D708BF)]
    public class TkAnimAnimNode : NMSTemplate
    {
        public NMSString0x10 NodeId;
        public NMSString0x10 AnimId;
        public NMSString0x40 PhaseIn;
        public TkCurveType PhaseCurve;
        public float PhseRangeBegin;
        public float PhaseRangeEnd;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
