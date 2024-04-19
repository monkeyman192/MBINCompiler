namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89FE6DD6DE4CAAD, NameHash = 0xF48C7408C8E42922)]
    public class GcInventoryLayout : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public int Level;
        /* 0x14 */ public int Slots;
    }
}
