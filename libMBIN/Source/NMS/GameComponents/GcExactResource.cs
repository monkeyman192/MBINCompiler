namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA9C048067CD89F4, NameHash = 0xBC849663458378CD)]
    public class GcExactResource : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSeed GenerationSeed;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 Filename;
    }
}
