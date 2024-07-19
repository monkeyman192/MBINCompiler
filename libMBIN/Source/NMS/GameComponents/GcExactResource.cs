namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA9C048067CD89F4, NameHash = 0xDD504892)]
    public class GcExactResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSeed GenerationSeed;
    }
}
