namespace libMBIN.Models.Structs
{
    public class GcRewardDisplayTechWindow : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TechID;
        public bool Damaged;
        public bool FullBox;
        [NMS(Size = 0x6)]
        public byte[] EndPadding;
    }
}
