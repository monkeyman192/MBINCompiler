namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcRefinerRecipeElement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcInventoryType Type;
        public int Amount;
    }
}
