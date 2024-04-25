namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC92DACAD69EBE5B6, NameHash = 0x5C2C30D664D4775B)]
    public class GcInventoryClass : NMSTemplate
    {
        // size: 0x4
        public enum InventoryClassEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryClassEnum InventoryClass;
    }
}
