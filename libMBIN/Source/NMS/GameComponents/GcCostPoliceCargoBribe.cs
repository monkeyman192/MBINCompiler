namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85157F11EA3E4F80, NameHash = 0xE0CD9FCE9BCD8413)]
    public class GcCostPoliceCargoBribe : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x4 */ public bool IncludeNipNip;
        [NMS(Index = 1)]
        /* 0x5 */ public bool OnlyCargoProbeInventories;
    }
}
