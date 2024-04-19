namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDBD0090BB16E436E, NameHash = 0xA889775D93694AA7)]
    public class GcCostStatCompare : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CostStringCanAfford;
        /* 0x20 */ public NMSString0x20A CostStringCantAfford;
        /* 0x40 */ public NMSString0x10 CompareAndSetStat;
        /* 0x50 */ public NMSString0x10 CoreStat;
    }
}
