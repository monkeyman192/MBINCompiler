using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x72B94AF46AAF48C4, NameHash = 0xEC73620F98D708BF)]
    public class TkAnimAnimNode : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AnimId;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 NodeId;
        [NMS(Index = 4)]
        /* 0x20 */ public float PhaseRangeBegin;
        [NMS(Index = 5)]
        /* 0x24 */ public float PhaseRangeEnd;
        [NMS(Index = 2)]
        /* 0x28 */ public NMSString0x40 PhaseIn;
        [NMS(Index = 3)]
        /* 0x68 */ public TkCurveType PhaseCurve;
    }
}
