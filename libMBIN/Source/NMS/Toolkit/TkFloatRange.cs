namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x189BAA6ED514CFD7, NameHash = 0x9CC8F67690234E64)]
    public class TkFloatRange : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Maximum;
        [NMS(Index = 0)]
        /* 0x4 */ public float Minimum;
    }
}
