namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x60)]
    public class GcCostStatCompare : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
        [NMS(Size = 0x20)]
        public string CostStringCanAfford;
        [NMS(Size = 0x20)]
        public string CostStringCantAfford;
    }
}
