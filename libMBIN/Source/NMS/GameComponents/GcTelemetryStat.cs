namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADCFA1F25E016AA, NameHash = 0xEBD25F53C92AC4C7)]
    public class GcTelemetryStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Type;
        [NMS(Index = 2)]
        /* 0x20 */ public int Value;
    }
}
