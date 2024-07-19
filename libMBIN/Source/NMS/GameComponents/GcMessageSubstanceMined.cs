namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD78249A7DD8D0B74, NameHash = 0x9FFB780F)]
    public class GcMessageSubstanceMined : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Substance;
        [NMS(Index = 0)]
        /* 0x10 */ public int Amount;
    }
}
