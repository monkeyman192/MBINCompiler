namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B7F4F97896F8311, NameHash = 0x629B830C)]
    public class GcCostStatCompare : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCanAfford;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x10 CanAffordIfMissionActive;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x10 CompareAndSetStat;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 CoreStat;
    }
}
