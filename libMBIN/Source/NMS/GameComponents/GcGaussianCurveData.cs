namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8038AC56819AFA1, NameHash = 0x2402A13D)]
    public class GcGaussianCurveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Mean;
        [NMS(Index = 1)]
        /* 0x4 */ public float StdDev;
    }
}
