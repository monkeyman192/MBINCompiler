namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x799D31C35A4AB865, NameHash = 0xA889775D93694AA7)]
    public class GcCostStatCompare : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCanAfford;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 CompareAndSetStat;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 CoreStat;
    }
}
