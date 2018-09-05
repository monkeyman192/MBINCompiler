namespace libMBIN.Models.Structs
{
    public class GcRewardSecondarySubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float Amountfactor;
        public bool RewardAsBlobs;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
