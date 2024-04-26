namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DF5A648209B3630, NameHash = 0xF9892B1499AD055A)]
    public class GcCostAnyCookedProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CostString;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 2)]
        /* 0x40 */ public int Index;
    }
}
