namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7857405C8A2A70F3, NameHash = 0x1C22335EC8C3634C)]
    public class GcCostStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CostAsString;
        /* 0x20 */ public NMSString0x10 Stat;
        /* 0x30 */ public NMSString0x10 StatGroup;
        /* 0x40 */ public int Value;
    }
}
