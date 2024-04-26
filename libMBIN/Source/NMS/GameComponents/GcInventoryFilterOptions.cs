namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49AD1545EF62E0F9, NameHash = 0x150B7D498E249B47)]
    public class GcInventoryFilterOptions : NMSTemplate
    {
        // size: 0x5
        public enum InventoryFilterEnum : uint {
            All,
            Substance,
            HighValue,
            Consumable,
            Deployable,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryFilterEnum InventoryFilter;
    }
}
