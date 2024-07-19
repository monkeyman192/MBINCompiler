namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x291A603BF262939C, NameHash = 0xDF07C8C6)]
    public class TkAnimPoseCorrelationData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ItemA;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 ItemB;
        [NMS(Index = 2)]
        /* 0x20 */ public float Correlation;
    }
}
