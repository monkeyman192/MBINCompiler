namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C92763FC7FC5B65, NameHash = 0x1C22335EC8C3634C)]
    public class GcCostStat : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A CostAsString;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 StatGroup;
        [NMS(Index = 2)]
        /* 0x40 */ public int Value;
    }
}
