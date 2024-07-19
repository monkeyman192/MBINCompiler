namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DF5A648209B3630, NameHash = 0x47C80238)]
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
