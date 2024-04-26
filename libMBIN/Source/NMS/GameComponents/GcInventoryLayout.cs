namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89FE6DD6DE4CAAD, NameHash = 0xF48C7408C8E42922)]
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
