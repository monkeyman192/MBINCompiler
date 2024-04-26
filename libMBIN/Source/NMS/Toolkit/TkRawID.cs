namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1BEB04AFCC15807A, NameHash = 0x8DE367576DE742FE)]
    public class TkRawID : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong Value0;
        [NMS(Index = 1)]
        /* 0x8 */ public ulong Value1;
    }
}
