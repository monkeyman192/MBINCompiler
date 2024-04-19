using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB444741FDF06771E, NameHash = 0xEC73620F98D708BF)]
    public class TkAnimAnimNode : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AnimId;
        /* 0x10 */ public NMSString0x10 NodeId;
        /* 0x20 */ public float PhaseRangeBegin;
        /* 0x24 */ public float PhaseRangeEnd;
        /* 0x28 */ public NMSString0x40 PhaseIn;
        /* 0x68 */ public TkCurveType PhaseCurve;
    }
}
