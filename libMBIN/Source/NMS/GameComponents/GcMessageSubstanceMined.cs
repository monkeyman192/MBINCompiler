namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE41F59D24256A6FE, NameHash = 0x2BC6A341CEA135BF)]
    public class GcMessageSubstanceMined : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Substance;
        [NMS(Index = 0)]
        /* 0x10 */ public int Amount;
    }
}
