namespace libMBIN.Models.Structs
{
    public class GcRewardSpecificProductRecipe : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public bool Slient;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
