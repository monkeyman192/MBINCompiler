namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FF1EC400D4AF7F0, NameHash = 0x817FD3EB)]
    public class GcInventoryLayout : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 2)]
        /* 0x10 */ public int Level;
        [NMS(Index = 0)]
        /* 0x14 */ public int Slots;
    }
}
