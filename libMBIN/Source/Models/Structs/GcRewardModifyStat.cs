namespace libMBIN.Models.Structs
{
    public class GcRewardModifyStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Stat;
        public int Amount;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
